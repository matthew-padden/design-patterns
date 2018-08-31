namespace GameConsole.Common
{
    using GameConsole.Common.Domain.Interpreters;
    using GameConsole.Common.Domain.Loader;
    using GameConsole.Common.Game;

    public interface IGameContext
    {
        Expression Interpreter { get; set; }

        GameType GameType { get; set; }

        IGame Game { get; set; }

        string Player { get; set; }

        string UserInput { get; set; }

        CommandType CurrentCommand { get; set; }
    }
}
