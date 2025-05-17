using Biblioteca.Data;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Repositorio
{
    public class RepositorioPrestamos : IRepositorioPrestamos
    {
        private readonly BibliotecaDBContext _context;
        public RepositorioPrestamos(BibliotecaDBContext context)
        {
            _context = context;
        }
        public async Task<Prestamo> Add(Prestamo prestamo)
        {
            await _context.Prestamos.AddAsync(prestamo);
            await _context.SaveChangesAsync();
            return prestamo;
        }
        public async Task Delete(int id)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);
            if (prestamo != null)
            {
                _context.Prestamos.Remove(prestamo);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<Prestamo?> Get(int id)
        {
            return await _context.Prestamos.FindAsync(id);
        }
        public async Task<List<Prestamo>> GetAll()
        {
            return await _context.Prestamos.ToListAsync();
        }
        public async Task Update(int id, Prestamo prestamo)
        {
            var prestamoactual = await _context.Prestamos.FindAsync(id);
            if (prestamoactual != null)
            {
                prestamoactual.EstudianteId = prestamo.EstudianteId;
                prestamoactual.LibroId = prestamo.LibroId;
                prestamoactual.Fecha_prestamo = prestamo.Fecha_prestamo;
                prestamoactual.Fecha_devolucion = prestamo.Fecha_devolucion;
                prestamoactual.Estado = prestamo.Estado;
                await _context.SaveChangesAsync();
            }
        }
    }
}
