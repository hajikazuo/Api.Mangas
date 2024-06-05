using Api.Mangas.Context;
using Api.Mangas.Entities;
using Api.Mangas.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Mangas.Repositories
{
    public class MangaRepository : Repository<Manga>, IMangaRepository
    {
        public MangaRepository(AppDbContext context) : base(context) { }
        public async Task<IEnumerable<Manga>> GetMangasPorCategoriaAsync(int categoriaId)
        {
            return await _db.Mangas.Where(b => b.CategoriaId == categoriaId).ToListAsync();
        }
        public async Task<IEnumerable<Manga>> LocalizaMangaComCategoriaAsync(string criterio)
        {
            return await _db.Mangas.AsNoTracking()
                .Include(b => b.Categoria)
                .Where(b => b.Titulo.Contains(criterio) ||
                            b.Autor.Contains(criterio) ||
                            b.Descricao.Contains(criterio) ||
                            b.Categoria.Nome.Contains(criterio))
                .ToListAsync();
        }
    }
}
