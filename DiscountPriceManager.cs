using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
    class DiscountPriceManager : IDiscountPriceService
    {
        public void campaignSale(Campaign campaign, Game game)
        {
            int discountedSale = game.gamePrice - (game.gamePrice * campaign.discount);

            Console.WriteLine(game.gameName+" oyununu "+campaign.campaignName+" kampanyasıyla "+discountedSale+" TL ye aldınız");
        }

        public void sale(Gamer gamer, Game game)
        {

            Console.WriteLine(game.gameName + " oyununu " +  game.gamePrice + " TL ye aldınız");
        }
    }
}
