using Microsoft.EntityFrameworkCore;

namespace ListarPessoaApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
