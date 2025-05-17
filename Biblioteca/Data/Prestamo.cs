using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Data
{
    public class Prestamo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe seleccionar un estudiante.")]
        public int EstudianteId { get; set; }
        virtual public ICollection<Estudiante>? Estudiante { get; set; }
        [Required(ErrorMessage = "Debe seleccionar un libro.")]
        public int LibroId { get; set; }
        virtual public ICollection<Libro>? Libro { get; set; }
        [Required(ErrorMessage = "La fecha de préstamo es obligatoria.")]
        public DateOnly Fecha_prestamo { get; set; }
        [Required(ErrorMessage = "La fecha de devolución es obligatoria.")]
        public DateOnly Fecha_devolucion { get; set; }
        [Required(ErrorMessage = "Debe especificar el estado del préstamo.")]
        public string? Estado { get; set; }
    }
}
