using LikeSpotify.Application.Conta.Dto;
using LikeSpotify.Application.Conta.Handle.Command;
using LikeSpotify.Application.Conta.Handle.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LikeSpotify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PlaylistController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("obter_playlist_login")]
        [HttpGet]
        public async Task<IActionResult> GetPlaylistLogin (string login)
        {
            return Ok(await _mediator.Send(new GetPlaylistQuery(login)));
        }

        [Route("criar_playlist")]
        [HttpPost]
        public async Task<IActionResult> Criar(PlaylistInputDto dto)
        {
            var result = await _mediator.Send(new CreatePlaylistCommand(dto));
            return Created($"{result.Playlist.Id}", result.Playlist);
        }
    }


}
