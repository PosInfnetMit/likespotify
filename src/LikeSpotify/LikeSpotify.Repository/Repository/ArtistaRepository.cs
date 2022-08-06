using LikeSpotify.Domain.Album;
using LikeSpotify.Domain.Album.Repository;
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
    internal class ArtistaRepository : Repository<Artista>, IArtistaRepository
    {
        public ArtistaRepository(LikeSpotifyContext likeSpotifyContext) : base(likeSpotifyContext)
        {
        }
        public async Task<Artista> ObterPorNome (string nome)
        {
            return await this.Query.Include(x => x.Albuns)
                                   .Where(x => x.Nome == nome)
                                   .FirstAsync();
        }




    }
}
