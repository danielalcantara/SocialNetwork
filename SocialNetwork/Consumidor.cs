using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class Consumidor
    {
        public int id { get; set; }

        public String nome { get; set; }

        public Consumidor(int pId, String pNome)
        {
            id = pId;
            nome = pNome;
        }
    }
}
