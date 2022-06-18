using LikeSpotify.CrossCutting.Entity;
using LikeSpotify.Domain.Album.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Domain.Album
{
    public class Midia : Entity<Guid>
    {
           
        public string Nome { get; set; }
        public int Ordem { get; set; }
        public Duracao Tempo_Midia { get; set; }


    }
}
