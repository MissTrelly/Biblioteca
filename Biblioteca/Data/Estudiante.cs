using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Data
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un grupo")]
        public string? Grupo { get; set; }
    }
}
