using LikeSpotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Album.Handler.Command
{
    public class CreateArtistaCommandRequest
    {
        public ArtistaOutputDto Artista { get; set; }

        public CreateArtistaCommandRequest (ArtistaOutputDto artista)
        {
            Artista = artista;
        }
    }
}
