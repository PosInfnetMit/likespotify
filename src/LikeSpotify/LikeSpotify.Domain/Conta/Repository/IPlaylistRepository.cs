using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Domain.Conta.Repository
{
    public  interface IPlaylistRepository : CrossCutting.Repository.IRepository<Playlist>
    {
    }
}
