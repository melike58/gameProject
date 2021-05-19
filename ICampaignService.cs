using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstracts
{
    interface ICampaignService
    {
        void add( Campaign campaign);
        void delete( Campaign campaign);
        void update( Campaign campaign);
    }
}
