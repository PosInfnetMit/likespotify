﻿using LikeSpotify.CrossCutting.Entity;
using LikeSpotify.Domain.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Domain.Conta
{
    public class Playlist : Entity<Guid>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Ordem_Execucao { get; set; }        
        public virtual IList<Midia> Midias { get; set; }


    }
}
