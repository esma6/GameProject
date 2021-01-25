using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager : ISaleManager
    {
        public void Buy(Gamer gamer, ICampaignService campaignService, Game game)
        {
            Console.WriteLine(gamer.FirstName+" adlı oyuncu için");
            campaignService.Discount(game);
        }
    }
}
