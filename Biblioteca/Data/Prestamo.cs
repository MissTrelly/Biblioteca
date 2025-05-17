using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Data
{
    public class Prestamo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe seleccionar un estudiante.")]
        public int Id_estudiante { get; set; }
        [Required(ErrorMessage = "Debe seleccionar un libro.")]
        public int Id_libro { get; set; }
        [Required(ErrorMessage = "La fecha de préstamo es obligatoria.")]
        public DateOnly Fecha_prestamo { get; set; }
        [Required(ErrorMessage = "La fecha de devolución es obligatoria.")]
        public DateOnly Fecha_devolucion { get; set; }
        [Required(ErrorMessage = "Debe especificar el estado del préstamo.")]
        public string? Estado { get; set; }
    }
}
