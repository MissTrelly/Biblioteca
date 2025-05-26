using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Data
{
    public class Prestamo : IValidatableObject
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe seleccionar un estudiante.")]
        public int EstudianteId { get; set; }
        public virtual ICollection<Estudiante>? Estudiante { get; set; }
        [Required(ErrorMessage = "Debe seleccionar un libro.")]
        public int LibroId { get; set; }
        public virtual ICollection<Libro>? Libro { get; set; }
        [Required(ErrorMessage = "La fecha de préstamo es obligatoria.")]
        public DateOnly Fecha_prestamo { get; set; }
        [Required(ErrorMessage = "La fecha de devolución es obligatoria.")]
        public DateOnly Fecha_devolucion { get; set; }
        [Required(ErrorMessage = "Debe especificar el estado del préstamo.")]
        public string? Estado { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Fecha_devolucion < Fecha_prestamo)
            {
                yield return new ValidationResult(
                    "La fecha de devolución no puede ser anterior a la fecha de préstamo.",
                    new[] { nameof(Fecha_devolucion) }
                );
            }
        }
    }
}
