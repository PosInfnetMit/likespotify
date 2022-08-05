using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using LikeSpotify.Application.Album.Handler.Query;
using LikeSpotify.Application.Album.Dto;
using LikeSpotify.Application.Album.Handler.Command;

namespace LikeSpotify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AlbumController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetAllAlbumQuery()));
        }

        [HttpPost()]
        public async Task<IActionResult> Criar(AlbumInputDto dto)
        {
            var result = await _mediator.Send(new CreateAlbumCommand(dto));
            return Created($"{result.Album.Id}", result.Album);
        }


    }
}
