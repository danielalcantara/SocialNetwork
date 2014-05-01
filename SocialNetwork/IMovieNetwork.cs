using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    interface IMovieNetwork
    {
        void adicionaConsumidor(int id, String nome);

        String getConsumidor(int c1);

        void adicionaAmizade(int c1, int c2);

        List<Consumidor> getAmigos(int c1);

        int getDistance(int c1, int c2);
    }
}
