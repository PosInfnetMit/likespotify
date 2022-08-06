using LikeSpotify.Application.Conta.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Conta.Service
{
    public interface IPlaylistService
    {
        Task<PlaylistOutputDto> Criar(PlaylistInputDto dto);
        Task<UsuarioOutputDto> ObterUsuarioPlaylist(string login);
    }
}
