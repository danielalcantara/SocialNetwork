using System;

namespace SocialNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            var movieNetwork = new MovieNetwork();
            var distance = 0;

            movieNetwork.AdicionaConsumidor(1, "Carlos Pereira");
            movieNetwork.AdicionaConsumidor(2, "Daniel Alcântara");
            movieNetwork.AdicionaConsumidor(3, "Mario Junior");
            movieNetwork.AdicionaConsumidor(4, "Antônio Magalhães");
            movieNetwork.AdicionaConsumidor(5, "Juliana Kabana");
            movieNetwork.AdicionaConsumidor(6, "Agatha Christie");

            movieNetwork.AdicionaAmizade(1, 2);
            movieNetwork.AdicionaAmizade(1, 4);
            movieNetwork.AdicionaAmizade(1, 6);
            movieNetwork.AdicionaAmizade(3, 2);
            movieNetwork.AdicionaAmizade(3, 6);

            distance = movieNetwork.GetDistance(1, 3);

            Console.WriteLine("A distância entre os consumidores {0} e {1} é: {2}", movieNetwork.GetConsumidor(1), movieNetwork.GetConsumidor(3), distance);
            Console.ReadKey();
        }
    }
}
