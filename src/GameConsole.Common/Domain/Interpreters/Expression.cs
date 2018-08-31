namespace GameConsole.Common.Domain.Interpreters
{
    using GameConsole.Common;

    public abstract class Expression
    {
        public abstract void Interpret(IGameContext context);
    }
}
