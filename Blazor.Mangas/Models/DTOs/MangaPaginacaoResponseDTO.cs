namespace Blazor.Mangas.Models.DTOs
{
    public class MangaPaginacaoResponseDTO
    {
        public List<MangaDTO>? Mangas { get; set; }
        public int TotalPaginas { get; set; }
    }
}
