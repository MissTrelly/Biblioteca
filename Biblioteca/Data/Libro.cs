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
        [StringLength(1000, ErrorMessage = "Máximo 1000 caracteres.")]
        public string? Categoria { get; set; }

        [Required(ErrorMessage = "Debes indicar si está disponible.")]
        public bool Disponible { get; set; }
    }
}