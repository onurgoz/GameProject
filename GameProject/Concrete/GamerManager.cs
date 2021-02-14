using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {

            if(_gamerCheckService.CheckIfRealGamer(gamer))
            {
                Console.WriteLine("Registration is complete.");
            }
            else
            {
                Console.WriteLine("registration information is incorrect.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated.");
        }
    }
}
