namespace GameConsole.Common
{
    using GameConsole.Common.Game;
    using GameConsole.Common.Loader;

    public interface IGameContext
    {
        GameStateType GameStateType { get; set; }

        GameState GameState { get; set; }

        GameType GameType { get; set; }

        IGame Game { get; set; }

        string Player { get; set; }

        string UserInput { get; set; }

        CommandType CurrentCommand { get; set; }
    }
}
