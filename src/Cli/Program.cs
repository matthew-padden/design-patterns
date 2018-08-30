namespace GameConsole.Cli
{
    using System;
    using GameConsole.Core.Domain;
    using GameConsole.Core.Domain.Interpreters;
    using GameConsole.Core.Loader;

    public class Program
    {
        public static void Main(string[] args)
        {
            var context = new GameContext();

            context.UserInput = GetGameSelectionInput();

            context.Interpreter = new GameSelectionInterpreter();
            context.Interpreter.Interpret(context);

            context.Game = GameFactory.Create(context.GameType);
            context.Game.Play();
        }

        private static string GetGameSelectionInput()
        {
            Console.Clear();

            Console.WriteLine("Please select a game");
            Console.WriteLine("0: Mario");
            Console.WriteLine("1: Donkey Kong");
            Console.Write("> ");

            return Console.ReadLine();
        }
    }
}
