using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Repository.Context
{
    public class LikeSpotifyContext : DbContext
    {
        public LikeSpotifyContext(DbContextOptions<LikeSpotifyContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LikeSpotifyContext).Assembly);
            base.OnModelCreating(modelBuilder);

        }


    }
}
