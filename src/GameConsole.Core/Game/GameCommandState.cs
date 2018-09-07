namespace GameConsole.Core.Game
{
    using System;
    using GameConsole.Common;
    using GameConsole.Common.Game;
    using GameConsole.Core.Domain.Interpreters;

    public class GameCommandState : GameState
    {
        public GameCommandState() : base(new CommandInterpreter())
        {
        }

        public override void LoadState(IGameContext context)
        {
            context.GameStateType = GameStateType.Playing;
        }

        public override void DisplayPrompt(IGameContext context)
        {
            Console.Write("Please input a command: ");
        }       

        public override void Interpret(ICommand command)
        {
            this.Interpreter.Interpret(command);
        }

        public override void DisplayResponse(IGameContext context)
        {
        }
    }
}
