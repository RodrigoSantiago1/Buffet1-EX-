using System;
namespace Buffet1.Models.Acesso
{
    public class Usuario : identityUser<Guid>
    {
        public string UserName { get; set; }
        public string senha { get; set; }
    }
}