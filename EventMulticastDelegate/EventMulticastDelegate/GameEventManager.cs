using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMulticastDelegate
{
    internal class GameEventManager
    {
        public delegate void GameEvent();
        public static event GameEvent OnGameStart, OnGameOver;
        public static void GameStartTrigger()
        {
            if (GameEventManager.OnGameStart != null)
            {
                Console.WriteLine("The game has started....");
                OnGameStart();
            }
        }

        public static void GameOverTrigger()
        {
            if (GameEventManager.OnGameOver != null)
            {
                Console.WriteLine("The game is over");
                OnGameOver();
            }
        }
    }
}
