namespace GameConsole.Core.Domain.Interpreters
{
    using GameConsole.Common;
    using GameConsole.Common.Interpreters;

    public class PlayerInterpreter : Expression
    {
        public override void Interpret(ICommand command)
        {
            command.GameContext.Player = command.UserInput;
        }
    }
}
