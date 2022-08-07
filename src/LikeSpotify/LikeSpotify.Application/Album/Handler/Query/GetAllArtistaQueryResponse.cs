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
        public IEnumerable<ArtistaOutputDto> Artistas { get; set; }

        public GetAllArtistaQueryResponse(IEnumerable<ArtistaOutputDto> artistas)
        {
            Artistas = artistas;
        }


    }
}
