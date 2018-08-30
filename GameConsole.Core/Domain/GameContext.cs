namespace GameConsole.Core.Domain
{
    using GameConsole.Common;
    using GameConsole.Common.Domain.Interpreters;
    using GameConsole.Common.Domain.Loader;

    public class GameContext : IGameContext
    {
        public Expression Interpreter { get; set; }

        public GameType GameType { get; set; }

        public IGame Game { get; set; }

        public string Player { get; set; }

        public string UserInput { get; set; }
    }
}
