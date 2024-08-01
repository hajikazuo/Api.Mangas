using System.ComponentModel.DataAnnotations;

namespace Blazor.Mangas.Models.DTOs
{
    public class CategoriaDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string? IconCSS { get; set; }
    }
}
