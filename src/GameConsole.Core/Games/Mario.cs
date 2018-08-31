namespace GameConsole.Core.Domain.Games
{
    using System;
    using GameConsole.Common.Loader;

    public class Mario : IGame
    {
        public void Play()
        {
            Console.WriteLine("Now playing Mario.");
        }
    }
}
