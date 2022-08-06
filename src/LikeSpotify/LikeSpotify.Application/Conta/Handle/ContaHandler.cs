using LikeSpotify.Application.Conta.Handle.Command;
using LikeSpotify.Application.Conta.Handle.Query;
using LikeSpotify.Application.Conta.Service;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Conta.Handle
{
    public class ContaHandler : IRequestHandler<CreateContaCommand, CreateContaCommandResponse>,
                               IRequestHandler<GetContaQuery,GetContaQueryResponse>
    {
        private readonly IContaService _contaService;

        public ContaHandler(IContaService contaService)
        {
            _contaService = contaService;
        }

        public async Task<CreateContaCommandResponse> Handle(CreateContaCommand request, CancellationToken cancellationToken)
        {
            var result = await _contaService.Criar(request.Usuario);
            return new CreateContaCommandResponse(result);
        }

        public async Task<GetContaQueryResponse> Handle(GetContaQuery request, CancellationToken cancellationToken)
        {
            var result = await _contaService.ObterPorLogin(request.Login, request.Password);
            return new GetContaQueryResponse(result);
        }
    }
}
