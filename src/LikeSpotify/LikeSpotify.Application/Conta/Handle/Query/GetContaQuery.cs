using LikeSpotify.Application.Conta.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Conta.Handle.Query
{
    public class GetContaQuery : IRequest<GetContaQueryResponse>
    {
        public GetContaQuery(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public string Login { get; set; }
        public string Password { get; set; }

        
    }
}
