using AutoMapper;
using LikeSpotify.Application.Album.Dto;
using LikeSpotify.CrossCutting.AzureBlobs;
using LikeSpotify.Domain.Album.Repository;

namespace LikeSpotify.Application.Album.Service
{
    public class ArtistaService : IArtistaService
    {

        private readonly IArtistaRepository _artistaRepository;
        private readonly IMapper mapper;
        private IHttpClientFactory _httpClientFactory;
        private AzureBlobStorage _storage;

        public ArtistaService(IArtistaRepository artistaRepository, IMapper mapper, IHttpClientFactory httpClientFactory,AzureBlobStorage azureBlobStorage)
        {
            _artistaRepository = artistaRepository;
            this.mapper = mapper;
            _httpClientFactory = httpClientFactory;
            _storage = azureBlobStorage;
        }

        public async Task<ArtistaOutputDto> Criar(ArtistaInputDto dto)
        {
            var artista = this.mapper.Map<LikeSpotify.Domain.Album.Artista>(dto);

            HttpClient httpClient = _httpClientFactory.CreateClient();

            using var response = await httpClient.GetAsync(dto.Foto);

            if (response.IsSuccessStatusCode)
            {
                using var stream = await response.Content.ReadAsStreamAsync();

                var fileName = $"{Guid.NewGuid()}.jpg";

                var pathStorage = await _storage.UploadFile(fileName, stream);

                artista.Foto = pathStorage;

            }

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
