namespace GameConsole.Core.Domain
{
    using GameConsole.Common;
    using GameConsole.Common.Domain.Interpreters;
    using GameConsole.Common.Domain.Loader;
    using GameConsole.Common.Game;

    public class GameContext : IGameContext
    {
        #region Properties

        public Expression Interpreter { get; set; }

        public GameType GameType { get; set; }

        public IGame Game { get; set; }

        public string Player { get; set; }

        public string UserInput { get; set; }

        public CommandType CurrentCommand { get; set; }

        #endregion
    }
}
