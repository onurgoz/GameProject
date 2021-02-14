using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign, Game game)
        {
            Console.WriteLine(campaign.CampaignName+" campaign has been applied to "+game.GameName+".");
        }

        public void Delete(Campaign campaign, Game game)
        {
            Console.WriteLine(campaign.CampaignName + " campaign has been deleted from " + game.GameName + ".");
        }

        public void update(Campaign campaign, Game game)
        {
            Console.WriteLine(campaign.CampaignName + " campaign has been updated from " + game.GameName + ".");
        }
    }
}
