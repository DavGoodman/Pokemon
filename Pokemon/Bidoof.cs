using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Bidoof : IPokemon
    {
        public int Health { get; set; }


        public Bidoof(int heath)
        {
            Health = heath;
        }


        public void LoseHealth(int lossAmount)
        {
            Health -= lossAmount;
        }

        public int Attack()
        {
            Console.WriteLine("Bidoof used Gnaw!");
            return Gnaw();
        }

        public int Gnaw()
        {
            var random = new Random();
            return random.Next(2, 6);
        }

    }
}
