using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Pikachu : IPokemon
    {
        public int Health { get; set; }

        public Pikachu(int health)
        {
            Health = health;
        }

        public void LoseHealth(int lossAmount)
        {
            Health -= lossAmount;
        }

        public int Attack()
        {
            Console.WriteLine("Pikachu used lightning bolt!");
            return LightningBolt();
        }

        public int LightningBolt()
        {
            var random = new Random();
            return random.Next(3, 7);
        }
    }
}
