namespace GameConsole.Core.Domain.Interpreters
{
    using GameConsole.Common;
    using GameConsole.Common.Domain.Interpreters;

    public class PlayerInterpreter : Expression
    {
        public override void Interpret(IGameContext context)
        {
            context.Player = context.UserInput;
        }
    }
}
