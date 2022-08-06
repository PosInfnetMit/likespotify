using LikeSpotify.Application.Conta.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Conta.Profile
{
    public  class ContaProfile : AutoMapper.Profile
    {
        public ContaProfile()
        {
            CreateMap<UsuarioInputDto, Domain.Conta.Usuario>();
            CreateMap<Domain.Conta.Usuario, UsuarioOutputDto>();

            CreateMap<PlaylistInputDto, Domain.Conta.Playlist>();
            CreateMap<Domain.Conta.Playlist, PlaylistOutputDto>();

        }



    }
}
