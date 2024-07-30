using Api.Mangas.Entities;

namespace Api.Mangas.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> Paginar<T>(this IQueryable<T> queryable, Paginacao paginacao)
        {
            return queryable
                .Skip((paginacao.Pagina - 1) * paginacao.QuantidadePorPagina)
                .Take(paginacao.QuantidadePorPagina);
        }
    }
}
