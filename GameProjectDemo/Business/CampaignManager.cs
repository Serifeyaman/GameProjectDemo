using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
