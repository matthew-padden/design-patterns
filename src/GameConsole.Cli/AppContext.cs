namespace GameConsole.Cli
{
    using System;
    using GameConsole.Core;

    /// <summary>
    /// This is an example of a facade. It is to act as a router of commands to the correct context.
    /// </summary>
    public class AppContext
    {
        public AppContext()
        {
            this.AppState = AppState.Stopped;
        }

        private GameContext GameContext => new GameContext();

        private AppState AppState { get; set; }

        public void Start()
        {
            this.AppState = AppState.Running;
            this.GameStart();
        }

        public void Stop()
        {
            if (this.AppState != AppState.Running)
                Console.WriteLine("Application is not in a running state.");
        }

        private void GameStart()
        {            
            this.GameContext.Start();
        }
    }
}
