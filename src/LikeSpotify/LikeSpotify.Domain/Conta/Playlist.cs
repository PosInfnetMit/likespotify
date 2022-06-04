using LikeSpotify.Domain.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Domain.Conta
{
    public class Playlista
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Ordem_Execucao { get; set; }
        public DateTime Data_Criacao { get; set; }
        public IList<Midia> Midias { get; set; }


    }
}
