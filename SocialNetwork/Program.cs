using System;

namespace SocialNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            var movieNetwork = new MovieNetwork();
            var distance = 0;

            movieNetwork.adicionaConsumidor(1, "Carlos Pereira");
            movieNetwork.adicionaConsumidor(2, "Daniel Alcântara");
            movieNetwork.adicionaConsumidor(3, "Mario Junior");
            movieNetwork.adicionaConsumidor(4, "Antônio Magalhães");
            movieNetwork.adicionaConsumidor(5, "Juliana Kabana");
            movieNetwork.adicionaConsumidor(6, "Agatha Christie");

            movieNetwork.adicionaAmizade(1, 2);
            movieNetwork.adicionaAmizade(1, 4);
            movieNetwork.adicionaAmizade(1, 6);
            movieNetwork.adicionaAmizade(3, 2);
            movieNetwork.adicionaAmizade(3, 6);

            distance = movieNetwork.getDistance(1, 3);

            Console.WriteLine("A distância entre os consumidores {0} e {1} é: {2}", movieNetwork.getConsumidor(1), movieNetwork.getConsumidor(3), distance);
            Console.ReadKey();
        }
    }
}
