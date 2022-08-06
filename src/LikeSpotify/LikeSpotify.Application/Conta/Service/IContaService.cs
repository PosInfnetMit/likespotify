using LikeSpotify.Application.Conta.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Conta.Service
{
    public interface IContaService
    {
        Task<UsuarioOutputDto> Criar (UsuarioInputDto dto);        
        Task<UsuarioOutputDto> ObterPorLogin(string login,string password);
        Task<PlaylistOutputDto> CriarPlayList(PlaylistInputDto dto);
        





    }
}
