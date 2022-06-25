using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMulticastDelegate
{
    internal class RenderingEngine
    {
        public RenderingEngine()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }
        private void StartGame()
        {
            Console.WriteLine("rendering engine started");
            Console.WriteLine("drawing visual...");

        }
        private void GameOver()
        {
            Console.WriteLine("rendering engine stopped");
        }
    }
}
