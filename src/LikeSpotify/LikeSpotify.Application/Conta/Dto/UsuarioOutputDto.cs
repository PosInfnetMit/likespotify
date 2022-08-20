using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Application.Conta.Dto
{
    public class UsuarioOutputDto
    {

        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IList<PlaylistOutputDto> Playlists { get; set; }


    }
}
