using LikeSpotify.CrossCutting.Entity;
using LikeSpotify.Domain.Album.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Domain.Album

{
    public class Artista : Entity<Guid>
    {
        public string Nome { get; set; }        
        public string Descricao { get; set; }
        public Boolean E_Banda { get; set; }

        public string Foto { get; set; }

        public virtual IList<Album> Albuns { get; set; }


        public void CreateAlbum(string nome, IList<Midia> midia)
        {
            var album = AlbumFactory.Create(nome, midia);
            this.Albuns.Add(album);
        }






    }
}
