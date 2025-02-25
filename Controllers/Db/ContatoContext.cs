using Microsoft.EntityFrameworkCore;
using SistemaDeCadastroContatos.Models;

namespace SistemaDeCadastroContatos.Controllers.Db
{
    public class ContatoContext : DbContext
    {
        public ContatoContext(DbContextOptions<ContatoContext> options) : base(options)
        {

        }

        public DbSet<Contato> ContatosMvc { get; set; }
    }
}
