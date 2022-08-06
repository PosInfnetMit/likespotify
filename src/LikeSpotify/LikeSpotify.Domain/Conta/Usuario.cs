using FluentValidation;
using LikeSpotify.CrossCutting.Entity;
using LikeSpotify.CrossCutting.Utils;
using LikeSpotify.Domain.Conta.Rules;
using LikeSpotify.Domain.Conta.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Domain.Conta
{
    public class Usuario : Entity<Guid>
    {
        public string Login { get; set; }
        public string Nome { get; set; }        

        public DateTime DtNascimento { get; set; }

        public Email Email { get; set; }

       public Password Password { get; set; }

        public virtual IList<Playlist> Playlists { get; set; }


        public void SetPassword()
        {
            this.Password.Valor = SecurityUtils.HashSHA1(this.Password.Valor);
        }

        public void Validate() =>
            new UsuarioValidator().ValidateAndThrow(this);



    }
}
