using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class OrderManager : IOrderService
    {
        ICampaignTypeService _campaignTypeService;
        public OrderManager(ICampaignTypeService campaignTypeService)
        {
            _campaignTypeService = campaignTypeService;
        }
        public void SatısYap(Gamer gamer)
        {
            _campaignTypeService.Campaign();
        }
               
    }
}