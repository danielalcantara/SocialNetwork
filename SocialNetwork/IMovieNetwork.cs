using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    interface IMovieNetwork
    {
        void AdicionaConsumidor(int id, String nome);

        String GetConsumidor(int c1);

        void AdicionaAmizade(int c1, int c2);

        List<Consumidor> GetAmigos(int c1);

        int GetDistance(int c1, int c2);
    }
}
