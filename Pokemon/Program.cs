namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPokemon> wildPokemons = new List<IPokemon>
            {
                new Pikachu(10),
                new Bidoof(12),
                new Piplup(9)
            };

            Magikarp magikarp = new Magikarp(6);

            var random = new Random();
            IPokemon wildPokemon = wildPokemons[random.Next(0, wildPokemons.Count)];

            while (true)
            {
                int splashDmg = magikarp.Attack();
                wildPokemon.LoseHealth(splashDmg);
                Console.WriteLine($"Magikarp HP: {magikarp.Health}\n" +
                                  $"{wildPokemon} HP: {wildPokemon.Health}");

                Console.ReadLine();

                int attackDmg = wildPokemon.Attack();
                magikarp.LoseHealth(attackDmg);
                Console.WriteLine($"Magikarp HP: {magikarp.Health}\n" +
                                  $"{wildPokemon} HP: {wildPokemon.Health}");



                if (magikarp.Health <= 0)
                {
                    Console.WriteLine("Game Over: Magikarp lost");
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}