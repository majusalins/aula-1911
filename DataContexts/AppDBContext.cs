using aula1911.Models;
using Microsoft.EntityFrameworkCore;

namespace aula1911.DataContexts
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Servidor> Servidor { get; set; }

    }
}
