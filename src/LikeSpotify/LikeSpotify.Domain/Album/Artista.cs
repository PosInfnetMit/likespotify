using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Domain.Album

{
    public class Artista
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public string Celular { get; set; }

        public bool E_Banda { get; set; }

        public string Foto { get; set; }

        public IList<Album> Albuns { get; set; }









    }
}
