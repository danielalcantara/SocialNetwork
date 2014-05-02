using System;

namespace SocialNetwork
{
    class Consumidor
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public Consumidor(int pId, String pNome)
        {
            Id = pId;
            Nome = pNome;
        }
    }
}
