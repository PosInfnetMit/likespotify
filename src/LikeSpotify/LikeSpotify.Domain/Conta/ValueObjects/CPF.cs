using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Domain.Conta.ValueObjects
{
    public class CPF
    {
        public CPF()
        { }

        public CPF(string value)
        {
            
        }

        public string Value { get; set; }
        public string FormatValue => Format(this.Value);


        private string Format(string value) => Convert.ToInt64(value).ToString(@"000\.000\.000\-00");
    }
}
