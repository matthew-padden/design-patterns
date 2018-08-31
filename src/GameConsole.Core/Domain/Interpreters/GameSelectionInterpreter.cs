namespace GameConsole.Core.Domain.Interpreters
{
    using GameConsole.Common;
    using GameConsole.Common.Domain.Interpreters;
    using GameConsole.Common.Domain.Loader;

    public class GameSelectionInterpreter : Expression
    {
        public override void Interpret(IGameContext context)
        {
            context.GameType = (GameType)int.Parse(context.UserInput); // bad algorithm but it works
        }
    }
}
