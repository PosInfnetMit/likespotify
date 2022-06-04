using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Domain.Conta.ValueObjects
{
    public class Password
    {
        public Password()
        {

        }
        public Password(string valor)
        {
            this.Valor = valor ?? throw new ArgumentNullException(nameof(Password));
        }

        public string Valor { get; set; }
    }
}
