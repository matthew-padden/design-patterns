namespace GameConsole.Common.Game
{
    using GameConsole.Common.Interpreters;

    public abstract class GameState
    {
        private readonly Expression interpreter;

        protected GameState(Expression interpreter)
        {
            this.interpreter = interpreter;
        }

        protected Expression Interpreter => this.interpreter;

        public abstract void LoadState(IGameContext context);

        public abstract void DisplayPrompt(IGameContext context);

        public abstract void Interpret(ICommand command);

        public virtual void Process(IGameContext context)
        {
        }

        public abstract void DisplayResponse(IGameContext context);

        public virtual void UnloadState(IGameContext context)
        {
        }
    }
}
