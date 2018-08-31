namespace GameConsole.Core.Game
{
    using GameConsole.Common;
    using GameConsole.Common.Game;
    using GameConsole.Core.Interpreters;

    public class GameSelectionState : GameState
    {
        public GameSelectionState() : base(new GameSelectionInterpreter())
        {
        }

        public override void Interpret(IGameContext context)
        {
            context.GameStateType = GameStateType.GameSelection;
            Interpreter.Interpret(context);
        }
    }
}
