using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Album.Dto
{
    public class MidiaOutputDto

    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Ordem { get; set; }
        public int Duracao { get; set; }
    }

}
