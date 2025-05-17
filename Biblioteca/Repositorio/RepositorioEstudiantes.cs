using Biblioteca.Data;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Repositorio
{
    public class RepositorioEstudiantes : IRepositorioEstudiantes
    {
        private readonly BibliotecaDBContext _context;
        public RepositorioEstudiantes(BibliotecaDBContext context)
        {
            _context = context;
        }
        public async Task<Estudiante> Add(Estudiante estudiante)
        {
            await _context.Estudiantes.AddAsync(estudiante);
            await _context.SaveChangesAsync();
            return estudiante;
        }
        public async Task Delete(int id)
        {
            var estudiante = await _context.Estudiantes.FindAsync(id);
            if(estudiante != null)
            {
                _context.Estudiantes.Remove(estudiante);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<Estudiante?> Get(int id)
        {
            return await _context.Estudiantes.FindAsync(id);
        }
        public async Task<List<Estudiante>> GetAll()
        {
            return await _context.Estudiantes.ToListAsync();
        }
        public async Task Update(int id, Estudiante estudiante)
        {
            var estudianteactual = await _context.Estudiantes.FindAsync(id);
            if(estudianteactual != null)
            {
                estudianteactual.Nombre = estudiante.Nombre;
                estudianteactual.Grupo = estudiante.Grupo;
                await _context.SaveChangesAsync();
            }
        }
    }
}
