namespace FactoryPattern
{
    using System;
    using FactoryPattern.GameLoader;
    using FactoryPattern.Games;

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
                Run();
        }

        private static void Run()
        {
            Console.Clear();

            Console.WriteLine("Please select a game");
            Console.WriteLine("0: Mario");
            Console.WriteLine("1: Donkey Kong");
            Console.Write("> ");

            var gameInput = Console.ReadLine();
            IGame game;

            try
            {
                game = GameFactory.Create((GameType)int.Parse(gameInput)); // should use an interpreter here
                game.Play();                
            }
            catch (ArgumentException ex)
            {
                Console.Write("Error: {0}", ex.Message);
            }

            Console.ReadKey();
        }
    }
}
