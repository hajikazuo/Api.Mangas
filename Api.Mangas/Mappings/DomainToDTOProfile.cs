using AutoMapper;
using Api.Mangas.DTOs;
using Api.Mangas.Entities;

namespace Api.Mangas.Mappings
{
    public class DomainToDTOProfile : Profile
    {
        public DomainToDTOProfile()
        {
            CreateMap<Categoria, CategoriaDTO>().ReverseMap();
            CreateMap<Manga, MangaDTO>().ReverseMap();

            CreateMap<Manga, MangaCategoriaDTO>()
                .ForMember(dto => dto.NomeCategoria, opt => opt.MapFrom(src => src.Categoria.Nome));
        }
    }
}
