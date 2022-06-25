using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMulticastDelegate
{
    internal class AudioSystem
    {
        public AudioSystem()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }
        private void StartGame()
        {
            Console.WriteLine("audio system start");
            Console.WriteLine("playing audio....");
        }
        private void GameOver()
        {
            Console.WriteLine("audio system stop");
        }
    }
}
