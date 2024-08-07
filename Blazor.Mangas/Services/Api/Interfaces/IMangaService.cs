﻿using Blazor.Mangas.Models.DTOs;

namespace Blazor.Mangas.Services.Api.Interfaces
{
    public interface IMangaService
    {
        Task<IEnumerable<MangaDTO>> GetMangas();
        Task<MangaDTO> GetManga(int id);
        Task<MangaDTO> CreateManga(MangaDTO mangaDto);
        Task<MangaDTO> UpdateManga(int id, MangaDTO mangaDto);
        Task<bool> DeleteManga(int id);
        Task<IEnumerable<MangaDTO>> GetMangasPorCategoria(int id);
        Task<IEnumerable<MangaDTO>> GetMangasPorTitulo(string titulo);
        Task<MangaPaginacaoResponseDTO> GetMangasPaginacao(int pagina, int quantidadePorPagina);
    }
}
