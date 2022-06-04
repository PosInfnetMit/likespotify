using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Domain.Album.Factory
{
    public static class AlbumFactory
    {

        public static Album Create(string nome, Midia midia)
        {
            if (midia == null)
                throw new ArgumentNullException("Para criar um album, tem que ter uma midia!");


            return new Album()
            {
                Midias = new List<Midia>() { midia }
            };

        }


        public static Album Create (string nome, IEnumerable<Midia> midias)
        {
            if(!midias.Any())
                throw new ArgumentNullException("Para criar um album, tem que ter uma midia!");


            return new Album()
            {
                Midias = midias.ToList()
            };
        }




    }
}
