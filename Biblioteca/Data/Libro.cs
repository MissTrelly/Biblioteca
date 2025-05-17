using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Data
{
    public class Libro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Título es obligatorio.")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "El Autor es obligatorio.")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string? Autor { get; set; }

        [Required(ErrorMessage = "La Categoría es obligatoria.")]
        [StringLength(100, ErrorMessage = "Máximo 1000 caracteres.")]
        public string? Categoria { get; set; }

        [Required(ErrorMessage = "La cantidad de disponibilidad es obligatoria.")]
        [Range(0, 999999999999999999, ErrorMessage = "No puede ser menor a 0")]
        public int Disponibles { get; set; }
    }
}
