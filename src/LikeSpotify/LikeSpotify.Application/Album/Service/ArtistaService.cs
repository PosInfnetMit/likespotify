using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LikeSpotify.Application.Album.Dto;
using LikeSpotify.Domain.Album.Repository;

namespace LikeSpotify.Application.Album.Service
{
    public class ArtistaService : IArtistaService
    {

        private readonly IArtistaRepository _artistaRepository;
        private readonly IMapper mapper;

        public ArtistaService(IArtistaRepository artistaRepository, IMapper mapper)
        {
            _artistaRepository = artistaRepository;
            this.mapper = mapper;
        }

        public async Task<ArtistaOutputDto> Criar(ArtistaInputDto dto)
        {
            var artista = this.mapper.Map<LikeSpotify.Domain.Album.Artista>(dto);
            await _artistaRepository.Save(artista);            
            return this.mapper.Map<ArtistaOutputDto>(artista); 
        }

        public async Task<ArtistaOutputDto> ObterPorArtista(string nome)
        {
            var artista = await _artistaRepository.ObterPorNome(nome);
            return this.mapper.Map<ArtistaOutputDto>(artista);
        }

        public async Task<IEnumerable<ArtistaOutputDto>> ObterTodos()
        {
            var artista = await _artistaRepository.GetAll();
            return this.mapper.Map<IEnumerable<ArtistaOutputDto>>(artista);
        }
    }
}
