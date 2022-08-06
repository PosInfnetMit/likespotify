using LikeSpotify.Application.Conta.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Conta.Handle.Command
{
    public  class CreateContaCommand : IRequest<CreateContaCommandResponse>
    {
        public CreateContaCommand(UsuarioInputDto usuario)
        {
            Usuario = usuario;
        }

        public UsuarioInputDto Usuario { get; set; }



    }
}
