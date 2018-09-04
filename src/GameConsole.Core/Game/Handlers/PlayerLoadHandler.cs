namespace GameConsole.Core.Game.Handlers
{
    using GameConsole.Common;
    using GameConsole.Common.Game;

    public class PlayerLoadHandler : GameHandler
    {
        public override void HandleRequest(IGameContext context)
        {            
            context.GameStateType = GameStateType.LoadPlayer;
            context.GameState = new LoadPlayerState();
        }
    }
}
