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
    public class UsuarioRepository :Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(LikeSpotifyContext likeSpotifyContext) : base(likeSpotifyContext)
        {
        }

        public async Task<Usuario> GetUserByPassword(string username, string password)
        {
            return await this.FindOneByCriteria(x => x.Email.Valor == username
                                                  && x.Password.Valor == password);
        }

        public async Task<Usuario> GetUserInPlaylist (string username)
        {
            return await this.Query.Include(x => x.Playlists)
                                   .Where(x => x.Login == username)
                                   .FirstAsync();


        }

    }
}
