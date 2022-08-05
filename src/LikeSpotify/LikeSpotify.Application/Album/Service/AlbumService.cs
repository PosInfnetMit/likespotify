using AutoMapper;
using LikeSpotify.Application.Album.Dto;
using LikeSpotify.Domain.Album.Repository;

namespace LikeSpotify.Application.Album.Service
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepository _albumRepository;
        private readonly IMapper _mapper;


        public AlbumService(IAlbumRepository albumRepository, IMapper mapper  )
        {
            _albumRepository = albumRepository;
            _mapper = mapper;   
        }

        public async Task<AlbumOutputDto> Criar(AlbumInputDto dto)
        {
            var album = _mapper.Map<LikeSpotify.Domain.Album.Album>(dto);

            await _albumRepository.Save(album);

            return _mapper.Map<AlbumOutputDto>(album);
        }

        public async Task<List<AlbumOutputDto>> ObterTodos()
        {
            var album = await _albumRepository.GetAll();
            return _mapper.Map<List<AlbumOutputDto>>(album);
        }
    }
}
