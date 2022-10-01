using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Conta.Handle.Command
{
    public class DeletePlaylistCommand : IRequest<DeletePlaylistCommandResponse>
    {
        public Guid PlayList { get; set; }

        public DeletePlaylistCommand(Guid playlist)
        {
            PlayList = playlist;
        }

    }
}
