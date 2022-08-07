using LikeSpotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Album.Service
{
    public  interface IArtistaService
    {
        Task<ArtistaOutputDto> Criar(ArtistaInputDto dto);
        Task<IEnumerable<ArtistaOutputDto>> ObterTodos();
        Task<ArtistaOutputDto> ObterPorArtista(string nome);
    }
}
