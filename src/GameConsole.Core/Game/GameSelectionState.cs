namespace GameConsole.Core.Game
{
    using System;
    using GameConsole.Common;
    using GameConsole.Common.Game;
    using GameConsole.Core.Domain.Loader;
    using GameConsole.Core.Interpreters;

    public class GameSelectionState : GameState
    {
        public GameSelectionState() : base(new GameSelectionInterpreter())
        {
        }

        public override void LoadState(IGameContext context)
        {
            context.GameStateType = GameStateType.GameSelection;
        }

        public override void DisplayPrompt(IGameContext context)
        {
            Console.WriteLine("1. Mario");
            Console.WriteLine("2. Donkey Kong");
            Console.Write("Please select a game: ");
        }        

        public override void Interpret(ICommand command)
        {
            this.Interpreter.Interpret(command);
        }

        public override void Process(IGameContext context)
        {
            context.Game = GameFactory.Create(context.GameType);
        }

        public override void DisplayResponse(IGameContext context)
        {
            //Console.WriteLine("You chose: {0}", context.GameState.);
        }
    }
}
