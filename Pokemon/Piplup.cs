using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Piplup : IPokemon
    {
        public int Health { get; set; }

        public Piplup(int health)
        {
            Health = health;
        }

        public void LoseHealth(int lossAmount)
        {
            Health -= lossAmount;
        }

        public int Attack()
        {
            Console.WriteLine("Piplub used splash!");
            return BubbleBlast();
        }

        public int BubbleBlast()
        {
            var random = new Random();
            return random.Next(4, 6);
        }
    }
}
