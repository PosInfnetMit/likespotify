using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Album.Dto
{

    public record ArtistaInputDto (
            [Required(ErrorMessage = "Nome do artista é obrigatório")] string Nome,
            [Required(ErrorMessage = "E-Mail do artista é obrigatório")] string Email,
            [Required(ErrorMessage = "Descrição é obrigatório")] string Descricao,bool EBanda);
    public record ArtistaOutputDto(Guid Id,string Nome, string Email, string Descricao, bool EBanda);


    public record AlbumInputDto(
        [Required(ErrorMessage = "Nome do album é obrigatório")] string Nome,
        [Required(ErrorMessage = "Data de lançamento é obrigatório")] DateTime DataLancamento);
    public record AlbumOutputDto(Guid Id, string Nome, DateTime DataLancamento);


    public record MidiaInputDto ([Required(ErrorMessage = "Nome da mídia é obrigatório")] string Nome, int Ordem, int Duracao);
    public record MidiaOutputDto(Guid Id,string Nome, int Ordem, int Duracao);











}
