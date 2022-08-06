using LikeSpotify.Application.Conta.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Conta.Handle.Query
{
    public class GetPlaylistQuery : IRequest<GetPlaylistQueryResponse>
    {
        public GetPlaylistQuery(string login)
        {
            Login = login;
            
        }

        public string Login { get; set; }
        

        
    }
}
