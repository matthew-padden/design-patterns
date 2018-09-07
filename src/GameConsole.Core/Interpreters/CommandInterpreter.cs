namespace GameConsole.Core.Domain.Interpreters
{
    using System;
    using GameConsole.Common;
    using GameConsole.Common.Interpreters;

    public class CommandInterpreter : Expression
    {
        public override void Interpret(ICommand command)
        {
            throw new NotImplementedException();
        }
    }
}
