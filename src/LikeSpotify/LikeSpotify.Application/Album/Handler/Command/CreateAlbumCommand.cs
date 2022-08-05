using LikeSpotify.Application.Album.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Album.Handler.Command
{
    public class CreateAlbumCommand : IRequest<CreateAlbumCommandResponse>
    {
        public AlbumInputDto Album { get; set; }

        public Guid IdBanda { get; set; }

        public CreateAlbumCommand(AlbumInputDto album)
        {
            Album = album;
        }
    }
}
