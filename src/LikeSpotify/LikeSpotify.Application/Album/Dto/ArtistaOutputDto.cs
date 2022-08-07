using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Album.Dto
{
    public class ArtistaOutputDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Descricao { get; set; }
        public string Foto { get; set; }
        public bool EBanda { get; set; }

    }
}
