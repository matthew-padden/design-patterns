namespace GameConsole.Common
{
    using GameConsole.Common.Game;

    public class Command : ICommand
    {
        public IGameContext GameContext { get; set; }

        public GameStateType GameStateType { get; set; }

        public CommandType CommandType { get; set; }

        public string UserInput { get; set; }

        public void Execute() { }
    }
}
