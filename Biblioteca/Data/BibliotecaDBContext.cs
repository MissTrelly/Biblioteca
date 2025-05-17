using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data
{
    public class BibliotecaDBContext : DbContext
    {
        public BibliotecaDBContext(DbContextOptions<BibliotecaDBContext> options) : base(options)
        {
        }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
