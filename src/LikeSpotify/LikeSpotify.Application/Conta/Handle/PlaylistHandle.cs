using LikeSpotify.Application.Conta.Handle.Command;
using LikeSpotify.Application.Conta.Handle.Query;
using LikeSpotify.Application.Conta.Service;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Conta.Handle
{
    public class PlaylistHandle : IRequestHandler<CreatePlaylistCommand, CreatePlaylistCommandResponse>,
                                  IRequestHandler<GetPlaylistQuery, GetPlaylistQueryResponse>,
                                  IRequestHandler<DeletePlaylistCommand, DeletePlaylistCommandResponse>


    {

        private readonly IPlaylistService _playlistService;

        public PlaylistHandle(IPlaylistService playlistService)
        {
            _playlistService = playlistService;
        }

        public async Task<CreatePlaylistCommandResponse> Handle(CreatePlaylistCommand request, CancellationToken cancellationToken)
        {
            var result = await _playlistService.Criar(request.Playlist);
            return new CreatePlaylistCommandResponse(result);
        }

        public async Task<GetPlaylistQueryResponse> Handle(GetPlaylistQuery request, CancellationToken cancellationToken)
        {
            var result = await _playlistService.ObterUsuarioPlaylist(request.Login);
            return new GetPlaylistQueryResponse(result);
        }

        public async Task<DeletePlaylistCommandResponse> Handle(DeletePlaylistCommand request, CancellationToken cancellationToken)
        {
            var result = await _playlistService.Deletar(request.PlayList);
            return new DeletePlaylistCommandResponse(result);
        }
    }
}
