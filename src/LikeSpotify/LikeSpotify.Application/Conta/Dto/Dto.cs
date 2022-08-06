using LikeSpotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Conta.Dto
{
    public record UsuarioInputDto(
        [Required(ErrorMessage = "Login é obrigatório")] string Login,
        [Required(ErrorMessage = "Nome é obrigatório")] string Nome,        
        [Required(ErrorMessage = "Data de nascimento é obrigatório")] DateTime DtNascimento,
        [Required(ErrorMessage = "E-Mail é obrigatório")] string Email,
        [Required(ErrorMessage = "Password é obrigatório")] string Password);

    public record UsuarioOutputDto(Guid Id,string Login,string Nome,string Cpf,DateTime DtNascimento,string Email,string Password,IList<PlaylistOutputDto>Playlists);

    public record PlaylistInputDto(
        [Required(ErrorMessage= "Nome da lista obrigatório")] string Nome,
        string Descricao,
        int Ordem_Execucao,
        [Required(ErrorMessage = "Necessário ao menos uma mídia")] IList<MidiaInputDto> Midias
        );

    public record PlaylistOutputDto(Guid Id,string Nome,string Descricao,int Ordem_Execucao,IList<MidiaOutputDto> Midias);

}
