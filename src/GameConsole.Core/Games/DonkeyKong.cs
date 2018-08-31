namespace GameConsole.Core.Domain.Games
{
    using System;
    using GameConsole.Common.Loader;

    public class DonkeyKong : IGame
    {
        public void Play()
        {
            Console.WriteLine("Now playing Donkey Kong.");
        }
    }
}
