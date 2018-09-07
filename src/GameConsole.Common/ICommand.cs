namespace GameConsole.Common
{
    using GameConsole.Common.Game;

    public interface ICommand
    {
        IGameContext GameContext { get; set; }

        GameStateType GameStateType { get; set; }

        CommandType CommandType { get; set; }

        string UserInput { get; set; }
    }
}
