using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstracts

{
    interface IDiscountPriceService
    {
        void sale(Gamer gamer,Game game);
        void campaignSale(Campaign campaign, Game game);
    }
}
