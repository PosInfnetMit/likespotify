using LikeSpotify.Application.Album.Dto;
using LikeSpotify.Application.Album.Handler.Command;
using LikeSpotify.Application.Album.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LikeSpotify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ArtistaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("todos_artistas")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetAllArtistaQuery()));
        }

        [Route("criar_artista")]
        [HttpPost()]
        public async Task<IActionResult> Criar(ArtistaInputDto dto)
        {
            var result = await _mediator.Send(new CreateArtistaCommand(dto));
            return Created($"{result.Artista.Id}", result.Artista);
        }



    }
}
