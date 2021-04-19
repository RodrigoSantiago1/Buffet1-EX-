using System;
using System.Threading.Tasks;
using Buffet1.Models.Acesso;
using Microsoft.AspNetCore.Identity;

namespace Buffet1.Models.Cadastro
{
    public class AcessoService
    {
        private readonly Conexao.Conexao _dbConexao;
        
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public AcessoService(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public AcessoService()
        {
        }

        public async Task registrarUsuario(string email,string senha)
        {
            var u = new Usuario()
            {
                UserName = email,
                senha = senha
            };

           var resultado = await _userManager.CreateAsync(u,senha);

           if (!resultado.Succeeded)
           {
               var lista = "";

               foreach (var IdentityError in resultado.Errors)
               {
                   lista += identityError.Description + " - ";
               }

               throw new Exception(lista);
           }

        }

        public bool logar(Usuario u)
        {

            var resultado = _signInManager.SignInAsync(u);

            if (resultado != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}