using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        /*
         * Método para retornar uma lista de consumidores que representa as conexões ou amizades que esse consumidor
         * possui. Para isso foi utilizado uma consulta LINQ ao invés de laços for por questões de desempenho.
         */
        public List<Consumidor> getAmigos(int c1)
        {
            return (from int[] amizadeArray in _amizades where amizadeArray[0] == c1 select _consumidores[amizadeArray[1]]).ToList();
        }

        /*
         * O calculo de distância foi feito com base no meu entendimento dos requisitos passados,
         * pode ser que eu esteja equivocado mais no meu entendimento esse metodo retorna o número de conexões em comum,
         * como parte do algoritimo do facebook que sugere novas amizades baseados em número de amizades em comum, fora outros algoritimos
         * mais complexos utilizados para sugestês de novas amizades, como por exemplo muitos interesses em comum, fan pages, etc.
         * 
         * Esse metedo retorna o número de conexões em comum, buscando as listas de amizades dos 2 consumidores e percorrendo ambas
         * e contando as intersecções, para isso utilizei uma consulta LINQ ao invés de laços for por questão de desempenho.
         */
        public int getDistance(int c1, int c2)
        {
            var amigosC1 = getAmigos(c1);
            var amigosC2 = getAmigos(c2);

            return (from amigoC1 in amigosC1 from amigoC2 in amigosC2 where amigoC1.id == amigoC2.id select amigoC1).Count();
        }
    }
}
