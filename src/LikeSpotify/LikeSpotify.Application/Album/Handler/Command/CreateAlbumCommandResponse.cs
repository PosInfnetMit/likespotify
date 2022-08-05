using LikeSpotify.Application.Album.Dto;

namespace LikeSpotify.Application.Album.Handler.Command
{
    public class CreateAlbumCommandResponse
    {
        public AlbumOutputDto Album { get; set; }

        public CreateAlbumCommandResponse(AlbumOutputDto album)
        {
            Album = album;
        }
    }
}
