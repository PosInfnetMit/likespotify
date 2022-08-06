using AutoMapper;
using LikeSpotify.Application.Conta.Dto;
using LikeSpotify.Domain.Conta.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Conta.Service
{
    public class PlaylistService : IPlaylistService
    {
        private readonly IPlaylistRepository _playlistRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public PlaylistService(IPlaylistRepository playlistRepository,
                               IUsuarioRepository usuarioRepository,
                               IMapper mapper)
        {
            _playlistRepository = playlistRepository;
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;   
        }

        public async Task<PlaylistOutputDto> Criar(PlaylistInputDto dto)
        {
            var playlist = _mapper.Map<Domain.Conta.Playlist>(dto);
            await _playlistRepository.Save(playlist);
            return _mapper.Map<PlaylistOutputDto>(playlist);
        }

        public async Task<UsuarioOutputDto> ObterUsuarioPlaylist(string login)
        {
            var usuario = await _usuarioRepository.GetUserInPlaylist(login);
            return _mapper.Map<UsuarioOutputDto>(usuario);
        }

    }
}
