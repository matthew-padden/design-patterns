namespace GameConsole.Core.Game.Handlers
{
    using GameConsole.Common;
    using GameConsole.Common.Game;

    public class GameCommandHandler : GameHandler
    {
        public override void HandleRequest(IGameContext context)
        {
            if (context.Game != null)
            {
                context.GameStateType = GameStateType.Playing;
                context.GameState = new GameCommandState();
            }                
        }
    }
}
