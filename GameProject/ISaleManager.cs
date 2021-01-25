using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISaleManager
    {
        void Buy(Gamer gamer,ICampaignService campaignService,Game game);
    }
}
