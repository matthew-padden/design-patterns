using System;

namespace GameConsole.Common.Game
{
    public abstract class GameHandler
    {
        protected GameHandler successor;

        public void SetSuccessor(GameHandler successor)
        {
            this.successor = successor;
        }

        public void Process(IGameContext context)
        {
            HandleRequest(context); // let the concrete implementation do its business

            context.GameState.LoadState(context);
            context.GameState.DisplayPrompt(context);

            context.UserInput = Console.ReadLine();

            context.GameState.Interpret(context);
            context.GameState.DisplayResponse(context);
            context.GameState.UnloadState(context);

            if (this.successor != null)
                this.successor.Process(context);
        }

        public abstract void HandleRequest(IGameContext context);
    }
}
