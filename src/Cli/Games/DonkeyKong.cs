namespace FactoryPattern.Games
{
    using System;

    public class DonkeyKong : IGame
    {
        public void Play()
        {
            Console.WriteLine("Now playing Donkey Kong.");
        }
    }
}
