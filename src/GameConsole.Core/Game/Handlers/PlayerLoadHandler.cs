namespace GameConsole.Core.Game.Handlers
{
    using GameConsole.Common;
    using GameConsole.Common.Game;

    public class PlayerLoadHandler : GameHandler
    {
        public override void HandleRequest(IGameContext context)
        {
            if (!string.IsNullOrWhiteSpace(context.Player))
                context.GameStateType = GameStateType.GameSelection;
        }
    }
}
