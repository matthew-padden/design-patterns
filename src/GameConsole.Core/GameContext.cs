namespace GameConsole.Core.Domain
{
    using GameConsole.Common;
    using GameConsole.Common.Game;
    using GameConsole.Common.Loader;
    using GameConsole.Core.Game;

    public class GameContext : IGameContext
    {
        #region Constructors

        public GameContext()
        {
            this.GameState = new LoadPlayerState();
        }

        #endregion

        #region Properties

        public GameStateType GameStateType { get; set; }

        public GameState GameState { get; set; }        

        public GameType GameType { get; set; }

        public IGame Game { get; set; }

        public string Player { get; set; }

        public string UserInput { get; set; }

        public CommandType CurrentCommand { get; set; }

        #endregion

        #region Methods

        public void Interpret()
        {
            GameState.Interpret(this);
        }

        #endregion
    }
}
