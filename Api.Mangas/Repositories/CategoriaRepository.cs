using Api.Mangas.Context;
using Api.Mangas.Entities;
using Api.Mangas.Repositories.Interfaces;

namespace Api.Mangas.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext context) : base(context) { }
    }
}
