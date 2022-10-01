using LikeSpotify.Application.Conta.Dto;

namespace LikeSpotify.Application.Conta.Handle.Command
{
    public class DeletePlaylistCommandResponse
    {
        public PlaylistOutputDto PlayList { get; set; }

        public DeletePlaylistCommandResponse(PlaylistOutputDto playList)
        {
            PlayList = playList;
        }   
    }
}
