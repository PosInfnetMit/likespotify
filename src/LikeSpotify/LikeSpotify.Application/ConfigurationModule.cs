﻿using LikeSpotify.Application.Album.Service;
using LikeSpotify.Application.Conta.Service;
using LikeSpotify.CrossCutting.AzureBlobs;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LikeSpotify.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Application.ConfigurationModule).Assembly);

            services.AddMediatR(typeof(Application.ConfigurationModule).Assembly);

            services.AddScoped<IArtistaService, ArtistaService>();
            services.AddScoped<IAlbumService, AlbumService>();
            services.AddScoped<IContaService, ContaService>();
            services.AddScoped<IPlaylistService, PlaylistService>();
            services.AddScoped<AzureBlobStorage>();


            return services;
        }
    }
}