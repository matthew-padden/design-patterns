namespace GameConsole.Common.Interpreters
{
    using GameConsole.Common;

    public abstract class Expression
    {
        public ICommand Command { get; set; }

        public abstract void Interpret(ICommand command);
    }
}
