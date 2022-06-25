using System;

namespace EventMulticastDelegate // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("SteelCow"); 
            Player p2 = new Player("DoggoSilva");

            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine engine = new RenderingEngine();

            GameEventManager.GameStartTrigger();
            

            Console.WriteLine("press any key to end the game");
            Console.ReadKey();
            GameEventManager.GameOverTrigger();
        }
    }
}
