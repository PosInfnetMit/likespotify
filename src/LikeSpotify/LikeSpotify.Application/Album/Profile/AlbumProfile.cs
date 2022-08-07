using LikeSpotify.Application.Album.Dto;

namespace LikeSpotify.Application.Album.Profile
{
    public class AlbumProfile : AutoMapper.Profile
    {

        public AlbumProfile()
        {

            CreateMap<AlbumInputDto, LikeSpotify.Domain.Album.Album>();
            CreateMap<LikeSpotify.Domain.Album.Album,AlbumOutputDto>();
            CreateMap<MidiaInputDto, LikeSpotify.Domain.Album.Midia>()
                .ForPath(x => x.Tempo_Midia.Valor, f => f.MapFrom(m => m.Duracao));
            
            CreateMap<LikeSpotify.Domain.Album.Midia, MidiaOutputDto>()
                .ForMember(x => x.Duracao, f => f.MapFrom(m => m.Tempo_Midia.Valor));

            CreateMap<ArtistaInputDto, LikeSpotify.Domain.Album.Artista>();
            CreateMap<LikeSpotify.Domain.Album.Artista, ArtistaOutputDto>();


        }



    }
}
