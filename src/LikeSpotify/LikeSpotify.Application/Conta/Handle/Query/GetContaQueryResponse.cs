﻿using LikeSpotify.Application.Conta.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Conta.Handle.Query
{
    public class GetContaQueryResponse
    {
        public GetContaQueryResponse(UsuarioOutputDto usuario)
        {
            Usuario = usuario;
        }

        public UsuarioOutputDto Usuario { get; set; }
    }
}
