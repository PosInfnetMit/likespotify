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
    public class ContaService : IContaService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IPlaylistRepository _playlistRepository;
        private readonly IMapper _mapper;

        public ContaService(IUsuarioRepository usuarioRepository, 
                            IPlaylistRepository playlistRepository, IMapper mapper)                            
        {
            _usuarioRepository = usuarioRepository;
            _playlistRepository = playlistRepository;
            _mapper = mapper;
        }

        public async Task<UsuarioOutputDto> Criar(UsuarioInputDto dto)
        {
            var usuario = _mapper.Map<Domain.Conta.Usuario>(dto);
            await _usuarioRepository.Save(usuario);
            return _mapper.Map<UsuarioOutputDto>(usuario);
        }

        public async Task<PlaylistOutputDto> CriarPlayList(PlaylistInputDto dto)
        {
            var playlist = _mapper.Map<Domain.Conta.Playlist>(dto); 
            await _playlistRepository.Save(playlist);
            return _mapper.Map<PlaylistOutputDto>(playlist);
            
        }

        

        public async Task<UsuarioOutputDto> ObterPorLogin(string login, string password)
        {
            var usuario = await _usuarioRepository.GetUserByPassword(login, password);  
            return _mapper.Map<UsuarioOutputDto>(usuario);
        }
    }
}
