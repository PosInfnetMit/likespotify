using LikeSpotify.Application.Album.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Album.Handler.Command
{
    public class CreateArtistaCommand : IRequest<CreateArtistaCommandRequest>
    {
        public ArtistaInputDto Artista { get; set; }

        public CreateArtistaCommand(ArtistaInputDto artista )
        {
            Artista = artista;  
        }


    }
}
