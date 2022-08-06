using LikeSpotify.Application.Album.Handler.Command;
using LikeSpotify.Application.Album.Handler.Query;
using LikeSpotify.Application.Album.Service;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Album.Handler
{
    public class ArtistaHandle : IRequestHandler<CreateArtistaCommand, CreateArtistaCommandRequest>,
                                 IRequestHandler<GetAllArtistaQuery, GetAllArtistaQueryResponse>


    {

        private readonly IArtistaService _artistaService;


        public ArtistaHandle(IArtistaService artistaService)
        {
            _artistaService = artistaService;
        }   

        public async Task<CreateArtistaCommandRequest> Handle(CreateArtistaCommand request, CancellationToken cancellationToken)
        {
            var result = await _artistaService.Criar(request.Artista);
            return new CreateArtistaCommandRequest(result);
        }

        public async Task<GetAllArtistaQueryResponse> Handle(GetAllArtistaQuery request, CancellationToken cancellationToken)
        {

            var result = await _artistaService.ObterTodos();
            return new GetAllArtistaQueryResponse(result);  

        }



    }
}
