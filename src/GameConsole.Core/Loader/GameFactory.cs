namespace GameConsole.Core.Domain.Loader
{
    using System;
    using GameConsole.Common.Loader;
    using GameConsole.Core.Domain.Games;

    public static class GameFactory
    {
        public static IGame Create(GameType game)
        {
            switch (game)
            {
                case GameType.Mario:
                    return new Mario();
                case GameType.DonkeyKong:
                    return new DonkeyKong();
                default:
                    throw new ArgumentException($"Cannot handle {game}");
            }
        }
    }
}
