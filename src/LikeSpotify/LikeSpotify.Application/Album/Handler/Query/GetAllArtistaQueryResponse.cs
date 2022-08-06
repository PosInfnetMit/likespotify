using LikeSpotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Album.Handler.Query
{
    public class GetAllArtistaQueryResponse
    {
        public IList<ArtistaOutputDto> Artistas { get; set; }

        public GetAllArtistaQueryResponse(IList<ArtistaOutputDto> artistas)
        {
            Artistas = artistas;
        }


    }
}
