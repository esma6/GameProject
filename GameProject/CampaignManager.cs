using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Discount(Game game)
        {
            game.GamePrice -= game.GamePrice * (0.5);
            Console.WriteLine(game.GameName+" oyununa kampanya uygulandı");
            Console.WriteLine("Yeni fiyat :"+game.GamePrice);
        }
    }
}
