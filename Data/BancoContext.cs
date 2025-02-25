using Microsoft.EntityFrameworkCore;
using SistemaDeCadastroContatos.Models;

namespace SistemaDeCadastroContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Contato> Contatos { get; set; }
    }
}
