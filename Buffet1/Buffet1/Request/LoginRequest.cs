namespace Buffet1.Request
{
    public class LoginRequest
    {
        private string email;
        private string senha;

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
    }
}