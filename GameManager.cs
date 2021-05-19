using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
    class GameManager : IGameService

    {
        public void add(Game game)
        {
            Console.WriteLine("Oyun Sisteme Yüklendi : "+game.gameName);
               
        }

        public void delete(Game game)
        {
            Console.WriteLine("Oyun Sistemden Silindi : " + game.gameName);
        }

        public void update(Game game)
        {
            Console.WriteLine("Oyun Sistemde Güncellendi : " + game.gameName);
        }
    }
}
