namespace GameConsole.Core.Domain.Interpreters
{
    using GameConsole.Common;
    using GameConsole.Common.Domain.Interpreters;
    using GameConsole.Common.Game;

    public class CommandInterpreter : Expression
    {
        public override void Interpret(IGameContext context)
        {
            context.CurrentCommand = (CommandType)int.Parse(context.UserInput);
        }
    }
}
