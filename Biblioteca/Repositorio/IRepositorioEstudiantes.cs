using Biblioteca.Data;

namespace Biblioteca.Repositorio
{
    public interface IRepositorioEstudiantes
    {
        Task<List<Estudiante>> GetAll();
        Task<Estudiante?> Get(int id);
        Task<Estudiante> Add(Estudiante estudiante);
        Task Update(int id, Estudiante estudiante);
        Task Delete(int id);
    }
}
