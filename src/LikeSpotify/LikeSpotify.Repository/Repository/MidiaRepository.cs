﻿using LikeSpotify.Domain.Album;
using LikeSpotify.Domain.Album.Repository;
using LikeSpotify.Repository.Context;
using LikeSpotify.Repository.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Repository.Repository
{
    public class MidiaRepository : Repository<Midia>, IMidiaRepository
    {
        public MidiaRepository(LikeSpotifyContext likeSpotifyContext) : base(likeSpotifyContext)
        {
        }
    }
}
