using System;
using System.Collections;
using System.Collections.Generic;

namespace SocialNetwork
{
    class MovieNetwork : IMovieNetwork
    {
        private readonly Dictionary<int, Consumidor> _consumidores;
        private readonly ArrayList _amizades;

        public MovieNetwork()
        {
            _consumidores = new Dictionary<int, Consumidor>();
            _amizades = new ArrayList();
        }

        /*
         * Esse método utiliza uma coleção do tipo dicionário para armazenar os consumidores
         */
        public void adicionaConsumidor(int id, string nome)
        {
            var consumidor = new Consumidor(id, nome);
            consumidor.id = id;
            consumidor.nome = nome;
            _consumidores.Add(id, consumidor);
        }

        public string getConsumidor(int c1)
        {
            return _consumidores[c1].nome;
        }

        public void adicionaAmizade(int c1, int c2)
        {
            int[] amizade = {c1, c2};
            _amizades.Add(amizade);
        }

        public List<Consumidor> getAmigos(int c1)
        {
            var amigos = new List<Consumidor>();

            foreach (var amizade in _amizades)
            {
                var amizadeArray = (int[]) amizade;
                if (amizadeArray[0] == c1)
                {
                    amigos.Add(_consumidores[amizadeArray[1]]);
                }
            }
            return amigos;
        }

        /*
         * O calculo de distância foi feito com base no meu entendimento dos requisitos passados,
         * pode ser que eu esteja equivocado mais no meu entendimento esse metodo retorna o número de conexões em comum,
         * como parte do algoritimo do facebook que sugere novas amizades baseados em número de amizades em comum, fora outros algoritimos
         * mais complexos utilizados para sugestês de novas amizades, como por exemplo muitos interesses em comum, fan pages, etc.
         * 
         * Esse metedo retorna o número de conexões em comum, buscando as listas de amizades dos 2 consumidores e percorrendo ambas
         * e contando as intersecções.
         */
        public int getDistance(int c1, int c2)
        {
            var amigosC1 = getAmigos(c1);
            var amigosC2 = getAmigos(c2);
            var distance = 0;

            foreach (var amigoC1 in amigosC1)
            {
                foreach (var amigoC2 in amigosC2)
                {
                    if (amigoC1.id == amigoC2.id)
                    {
                        distance++;
                    }
                }
            }

            return distance;
        }
    }
}
