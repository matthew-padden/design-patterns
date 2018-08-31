namespace GameConsole.Cli
{
    using System;
    using GameConsole.Core.Domain;
    using GameConsole.Core.Domain.Loader;

    public class Program
    {
        public static void Main(string[] args)
        {
            var context = new GameContext();

            context.UserInput = GetPlayerNameInput();
            context.Interpret(); // how do we change the interpreter?

            Console.WriteLine("Welcome {0}", context.Player);
            Console.ReadKey();

            Console.Clear();
            context.UserInput = GetGameSelectionInput();
            context.Interpret(); // will still be using the same default interpreter

            Console.Clear();
            context.Game = GameFactory.Create(context.GameType);
            context.Game.Play();

            context.UserInput = GetCommandInput();
            context.Interpret(); // will still be using the same default interpreter

            Console.ReadKey();
        }

        private static string GetPlayerNameInput()
        {
            Console.Write("Please input player name: ");
            return Console.ReadLine();
        }

        private static string GetGameSelectionInput()
        {
            Console.WriteLine("1. Mario");
            Console.WriteLine("2. Donkey Kong");
            Console.Write("Please select a game: ");
            return Console.ReadLine();
        }

        private static string GetCommandInput()
        {
            Console.Write("Please input a command: ");
            return Console.ReadLine();
        }
    }
}
