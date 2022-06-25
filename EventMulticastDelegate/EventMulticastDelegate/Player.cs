using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMulticastDelegate
{
    internal class Player
    {
        public string Name { get; set; }
        public Player(string name)
        {
            Name = name;
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }
        private void StartGame()
        {
            Console.WriteLine($"spawning player with ID: {Name}");
        }
        private void GameOver()
        {
            Console.WriteLine($"Remove player with ID: {Name}");
        }
    }
}
