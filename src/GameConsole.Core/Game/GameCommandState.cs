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

        public override void DisplayPrompt(IGameContext context)
        {
            Console.Write("Please input a command: ");
        }       

        public override void Interpret(IGameContext context)
        {
            context.GameStateType = GameStateType.Playing;
            this.Interpreter.Interpret(context);
        }

        public override void DisplayResponse(IGameContext context)
        {
            Console.WriteLine("Welcome {0}", context.Player);
        }
    }
}
