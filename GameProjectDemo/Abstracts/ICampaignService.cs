using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
