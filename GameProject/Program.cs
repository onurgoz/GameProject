using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entity;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Gamer Onur = new Gamer { Id = 1, FirtName = "Onur", LastName = "Göz", NationalityId = "17462618612", DateOfBirth = new DateTime(1998, 7, 10) };
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(Onur);
            GameManager gameManager = new GameManager();
            Game game1 = new Game { GameId=0,GameName="Game0",GamePrice=15};
            Game game2 = new Game { GameId=1,GameName="Game1",GamePrice=20};
            Game game3 = new Game { GameId=2,GameName="Game2",GamePrice=25};
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { CampaignId = 1, CampaignLevel = 10, CampaignName = "campany1" },game1);
            gameManager.GameSales(game2, Onur);
        }
    }
}
