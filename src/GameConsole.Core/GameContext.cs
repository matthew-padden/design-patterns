namespace GameConsole.Core
{
    using GameConsole.Common;
    using GameConsole.Common.Game;
    using GameConsole.Common.Loader;
    using GameConsole.Core.Game.Handlers;

    public class GameContext : IGameContext
    {
        // chain of responsibility pattern
        private readonly GameHandler playerLoadHandler = new PlayerLoadHandler();
        private readonly GameHandler gameSelectionHandler = new GameSelectionHandler();
        private readonly GameHandler gameCommandHandler = new GameCommandHandler();

        #region Constructors

        public GameContext()
        {
            // chaining
            this.playerLoadHandler.SetSuccessor(this.gameSelectionHandler);
            this.gameSelectionHandler.SetSuccessor(this.gameCommandHandler);
            this.GameHandler = this.playerLoadHandler;
        }

        #endregion

        #region Properties

        public GameHandler GameHandler { get; set; }

        public GameStateType GameStateType { get; set; }

        public GameState GameState { get; set; }

        public GameType GameType { get; set; }

        public IGame Game { get; set; }

        public string Player { get; set; }

        public CommandType CurrentCommand { get; set; }

        #endregion

        #region Methods

        public void Start() // example of implementing the fascade pattern to defer the responsibility to the GameHandler
        {
            this.GameHandler.Process(this);
        }

        #endregion
    }
}
