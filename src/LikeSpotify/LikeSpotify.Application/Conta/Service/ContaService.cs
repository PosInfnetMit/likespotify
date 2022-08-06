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
        private readonly IMapper _mapper;

        public ContaService(IUsuarioRepository usuarioRepository,
                            IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;

            _mapper = mapper;
        }

        public async Task<UsuarioOutputDto> Criar(UsuarioInputDto dto)
        {
            var usuario = _mapper.Map<Domain.Conta.Usuario>(dto);
            await _usuarioRepository.Save(usuario);
            return _mapper.Map<UsuarioOutputDto>(usuario);
        }


        public async Task<UsuarioOutputDto> ObterPorLogin(string login, string password)
        {
            var usuario = await _usuarioRepository.GetUserByPassword(login, password);
            return _mapper.Map<UsuarioOutputDto>(usuario);
        }
    }
}
