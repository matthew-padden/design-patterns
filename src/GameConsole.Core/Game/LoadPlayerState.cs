namespace GameConsole.Core.Game
{
    using System;
    using GameConsole.Common;
    using GameConsole.Common.Game;
    using GameConsole.Core.Domain.Interpreters;

    public class LoadPlayerState : GameState
    {
        public LoadPlayerState() : base(new PlayerInterpreter())
        {
        }

        public override void DisplayPrompt(IGameContext context)
        {
            Console.Write("Please input player name: ");
        }

        public override void DisplayResponse(IGameContext context)
        {
            Console.WriteLine("Welcome {0}", context.Player);
        }

        public override void Interpret(IGameContext context)
        {
            context.GameStateType = GameStateType.LoadPlayer;
            this.Interpreter.Interpret(context);
        }
    }
}
