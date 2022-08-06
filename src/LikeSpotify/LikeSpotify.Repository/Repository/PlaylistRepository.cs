using LikeSpotify.Domain.Conta;
using LikeSpotify.Domain.Conta.Repository;
using LikeSpotify.Repository.Context;
using LikeSpotify.Repository.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Repository.Repository
{  

    public class PlaylistRepository : Repository<Playlist>, IPlaylistRepository
    {
        public PlaylistRepository(LikeSpotifyContext likeSpotifyContext) : base(likeSpotifyContext)
        {
        }

        

    }
}
