namespace GameConsole.Core.Interpreters
{
    using GameConsole.Common;
    using GameConsole.Common.Interpreters;
    using GameConsole.Common.Loader;

    public class GameSelectionInterpreter : Expression
    {
        public override void Interpret(ICommand command)
        {
            //context.GameType = (GameType)int.Parse(context.UserInput); // bad algorithm but it works
        }
    }
}
