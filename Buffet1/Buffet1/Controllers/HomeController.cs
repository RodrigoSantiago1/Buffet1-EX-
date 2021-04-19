using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Buffet1.Models.Acesso;
using Buffet1.Models.Cadastro;
using Buffet1.Request;
using Buffet1.Views.Cadastro;
using Buffet1.Models.Cliente;
using Buffet1.Views.Login;


namespace Buffet1.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly AcessoService _acessoService;
        private readonly Conexao.Conexao _dbConexao;
     
        public HomeController(AcessoService acessoService,Conexao.Conexao dbConexao)
        {
            _acessoService = acessoService;
            _dbConexao = dbConexao;
        }

        public ActionResult Index()
        {
          
            return View();
        }

        public ActionResult Termos()
        {
            return View();
        }
        
        public ActionResult Privacidade()
        {
            return View();
        }

     
        [HttpGet]
        public ActionResult Cadastro()
        {
            var viewModel = new CadastrarViewModel();

            viewModel.msg =(string) TempData["msg"];
            return View();
        }
        
        [HttpPost]
        public async Task<RedirectResult> Cadastro(CadastroRequest request)
        {
            var redirecionar = "/Home/Cadastro";
            var email = request.Email;
            var senha = request.Senha;
            var senhaConfirma = request.SenhaConfirma;

            if (email == null)
            {
                TempData["msg"] = "Informe o email";
                return Redirect(redirecionar);
            }
            

            try
            {
               await _acessoService.registrarUsuario(email,senha);
                return Redirect("/Home/Logar"); 
                TempData["msg"] = "Cadastro realizado com sucesso";
            }
            catch (Exception exception)
            {
                TempData["msg"] = "Erro no Cadastro";
            }
            return Redirect(redirecionar);
        }

        [HttpPost]
        public ActionResult Logar(LoginRequest request)
        {
            var redirecionar = "/Home/Logar";
            
            var email = request.Email;
            var senha = request.Senha;
            
            
            if (email == null || senha == null)
            {
                TempData["msg"] = "Email ou senha estao incorretos";
                return Redirect(redirecionar);
            }

            try
            {
                Usuario u = new Usuario();
                u.senha = senha;
                u.UserName = email;

                AcessoService a = new AcessoService();
                a.logar(u);
                
                return Redirect("/Home/Interno"); 
            }
            catch (Exception e)
            {
                TempData["msg"] = "Erro ao logar";
            }
           
            
            return Redirect(redirecionar);
        }
        
        public ActionResult Logar()
        {
            var viewModel = new LogarView();

            viewModel.msg =(string) TempData["msg"];
            return View();
        }
        
        
        public ActionResult RecuperacaoConta()
        {
            return View();
        }
        
         
        public ActionResult Interno()
        {
            return View();
        }
        
        public ActionResult Painel()
        {
            return View();
        }
        
        public ActionResult Ajuda()
        {
            return View();
        }
        
          
        public ActionResult sessao1()
        {
            return View();
        }
        
        public ActionResult sessao2()
        {
            return View();
        }
        
        public ActionResult sessao3()
        {
            return View();
        }
    }
}