using LikeSpotify.Application.Conta.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Conta.Handle.Command
{
    public class CreatePlaylistCommandResponse
    {
        public CreatePlaylistCommandResponse(PlaylistOutputDto playlist)
        {
            Playlist = playlist;
        }

        public PlaylistOutputDto Playlist { get; set; }


    }
}
