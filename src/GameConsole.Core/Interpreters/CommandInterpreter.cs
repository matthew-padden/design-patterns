namespace GameConsole.Core.Domain.Interpreters
{
    using GameConsole.Common;
    using GameConsole.Common.Game;
    using GameConsole.Common.Interpreters;

    public class CommandInterpreter : Expression
    {
        public override void Interpret(IGameContext context)
        {
            context.CurrentCommand = (CommandType)int.Parse(context.UserInput);
        }
    }
}
