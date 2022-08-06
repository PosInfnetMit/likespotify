using LikeSpotify.Application.Conta.Dto;
using LikeSpotify.Application.Conta.Handle.Command;
using LikeSpotify.Application.Conta.Handle.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LikeSpotify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("obter_login")]
        [HttpGet]
        public async Task<IActionResult> GetLogin(string login, string password)
        {
            return Ok(await _mediator.Send(new GetContaQuery(login, password)));

        }

        [Route("criar_login")]
        [HttpPost]
        public async Task<IActionResult> CriarLogin(UsuarioInputDto dto)
        {
            var result = await _mediator.Send(new CreateContaCommand(dto));
            return Created($"{result.Usuario.Id}", result.Usuario);

        }








    }
}
