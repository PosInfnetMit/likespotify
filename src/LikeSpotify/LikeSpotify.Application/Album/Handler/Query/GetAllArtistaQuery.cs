using MediatR;

namespace LikeSpotify.Application.Album.Handler.Query
{
    public class GetAllArtistaQuery : IRequest<GetAllArtistaQueryResponse>
    {
        public string Artista { get; set; }
        public GetAllArtistaQuery()
        {
        }

        public GetAllArtistaQuery(string artista)
        {
            Artista = artista;
        }   
    }
}
