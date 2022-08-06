using LikeSpotify.CrossCutting.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Domain.Album
{
    public class Album : Entity<Guid>
    {
        
        public int Nome { get; set; }
        public DateTime DataLancamento { get; set; }
        public virtual IList<Midia> Midias { get; set; }


    }
}
