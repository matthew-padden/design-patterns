namespace FactoryPattern.Games
{
    using System;

    public class Mario : IGame
    {
        public void Play()
        {
            Console.WriteLine("Now playing Mario.");
        }
    }
}
