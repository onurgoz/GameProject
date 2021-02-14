using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;

using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService, IGameSalesService
    {
        
        public void Add(Game game)
        {
            Console.WriteLine(game.GameId+" game has been added.Price "+game.GamePrice+" Dollars");
        }

        public void Delete(Game game)
        {
            
            Console.WriteLine(game.GameId + " game has been removed.");
        }

        public void GameSales(Game game, Gamer gamer)
        {
            gamer.games.Add(game);
            Console.WriteLine(game.GameName+" game has been added to "+ gamer.FirtName+"'s library.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameId + " game has been updated.Name is "+game.GameName+".Price "+game.GamePrice+" Dollars");
        }
    }
}
