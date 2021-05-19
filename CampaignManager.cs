using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
    class CampaignManager : ICampaignService

    {
        public void add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi : "+campaign.campaignName);
        }

        public void delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi : " + campaign.campaignName);
        }

        public void update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi : " + campaign.campaignName);
        }
    }
}
