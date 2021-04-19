using Buffet1.Models.Cliente;
using Microsoft.EntityFrameworkCore;

namespace Buffet1.Conexao
{
    public class Conexao : DbContext
    {
        public DbSet<ClienteEntity> clientes { get; set; }
        
        public Conexao(DbContextOptions<Conexao> options)
            : base(options)
        {

        }
    }
    //services.AddDbcontext<databaseContex> (
    //(options.mySql(Configurations.GetConnectionString ("db")) );

    //"conectionsStrings":
    //{
        //db : "server = localHost; User = root; Database = pwa "
    //}
}