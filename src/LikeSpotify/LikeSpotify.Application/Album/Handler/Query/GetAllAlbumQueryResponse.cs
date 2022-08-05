using LikeSpotify.Application.Album.Dto;

namespace LikeSpotify.Application.Album.Handler.Query
{
    public class GetAllAlbumQueryResponse
    {
        public IList<AlbumOutputDto> Albums { get; set; }

        public GetAllAlbumQueryResponse(IList<AlbumOutputDto> albums)
        {
            Albums = albums;
        }
    }
}
