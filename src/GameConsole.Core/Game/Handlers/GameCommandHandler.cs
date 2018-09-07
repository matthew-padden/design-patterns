namespace GameConsole.Core.Game.Handlers
{
    using GameConsole.Common;
    using GameConsole.Common.Game;

    public class GameCommandHandler : GameHandler
    {
        public override void HandleRequest(IGameContext context)
        {
            context.GameStateType = GameStateType.Playing;
            context.GameState = new GameCommandState();
        }
    }
}
