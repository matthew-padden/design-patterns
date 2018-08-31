namespace GameConsole.Common.Game
{
    using GameConsole.Common.Interpreters;

    public abstract class GameState
    {
        private readonly Expression _interpreter;

        protected GameState(Expression interpreter)
        {
            this._interpreter = interpreter;
        }

        protected Expression Interpreter => this._interpreter;

        public abstract void Interpret(IGameContext context);
    }
}
