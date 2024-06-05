using Api.Mangas.Entities;

namespace Api.Mangas.Repositories.Interfaces
{
    public interface IMangaRepository : IRepository<Manga>
    {
        Task<IEnumerable<Manga>>
        GetMangasPorCategoriaAsync(int categoriaId);

        Task<IEnumerable<Manga>>
            LocalizaMangaComCategoriaAsync(string criterio);
    }
}
