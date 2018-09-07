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

            var command = new Command();
            command.UserInput = Console.ReadLine();

            // TODO: Do stuff with command

            context.CurrentCommand = command.CommandType;

            context.GameState.Interpret(command);
            context.GameState.Process(context);
            context.GameState.DisplayResponse(context);
            context.GameState.UnloadState(context);

            if (this.successor != null)
                this.successor.Process(context);
        }

        public abstract void HandleRequest(IGameContext context);
    }
}
