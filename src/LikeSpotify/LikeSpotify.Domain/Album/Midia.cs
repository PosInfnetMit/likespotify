using LikeSpotify.CrossCutting.Entity;
using LikeSpotify.Domain.Album.ValueObject;
using LikeSpotify.Domain.Conta;
using System;
using System.Collections.Generic;

namespace LikeSpotify.Domain.Album
{
    public class Midia : Entity<Guid>
    {
           
        public string Nome { get; set; }
        public int Ordem { get; set; }
        public Duracao Tempo_Midia { get; set; }
        public virtual IList<Playlist> Playlists { get; set; }


    }
}
