namespace GameConsole.Core.Game
{
    using GameConsole.Common;
    using GameConsole.Common.Game;
    using GameConsole.Core.Domain.Interpreters;

    public class LoadPlayerState : GameState
    {
        public LoadPlayerState() : base(new PlayerInterpreter())
        {
        }

        public override void Interpret(IGameContext context)
        {
            context.GameStateType = GameStateType.LoadPlayer;
            this.Interpreter.Interpret(context);
        }
    }
}
