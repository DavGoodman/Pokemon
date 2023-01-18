using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Magikarp : IPokemon
    {
        public int Health { get; set; }
        public bool isUseless { get; set; }

        public Magikarp(int health)
        {
            Health = health;
            isUseless = true;
        }

        public int Attack()
        {
            Console.WriteLine("Magikarp used splash!");
            return splash();
        }

        public int splash()
        {
            var random = new Random();
            return random.Next(1, 3);
        }
        public void LoseHealth(int lossAmount)
        {
            Health -= lossAmount;
        }
    }
}
