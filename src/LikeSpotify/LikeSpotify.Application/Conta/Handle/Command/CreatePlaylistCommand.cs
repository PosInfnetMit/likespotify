using LikeSpotify.Application.Conta.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Conta.Handle.Command
{
    public class CreatePlaylistCommand : IRequest<CreatePlaylistCommandResponse>
    {
        public CreatePlaylistCommand(PlaylistInputDto playlist)
        {
            Playlist = playlist;
        }

        public PlaylistInputDto Playlist { get; set; }

        



    }
}
