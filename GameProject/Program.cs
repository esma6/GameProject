using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "Esma";
            gamer.LastName = "Karagülle";
            gamer.DateOfBirth = new DateTime(1998, 12, 9);
            gamer.NationalityId = "123456788910";

            Game game = new Game();
            game.GameName = "PUBG";
            game.GamePrice = 150;

            ICampaignService campaignService = new CampaignManager();
            SaleManager saleManager = new SaleManager();
            saleManager.Buy(gamer, campaignService, game);

        }
    }
}
