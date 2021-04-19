using Microsoft.Ajax.Utilities;

namespace Buffet1.Request
{
    public class CadastroRequest
    {
        private string email;
        private string senha;
        private string senhaConfirma;

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Senha
        {
            get => senha;
            set => senha = value;
        }

        public string SenhaConfirma
        {
            get => senhaConfirma;
            set => senhaConfirma = value;
        }
    }
}