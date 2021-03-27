using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entites;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("New Game Added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game Deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game Data Updated");
        }
    }
}
