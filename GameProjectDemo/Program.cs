using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //farklı doğrulama altternatifleriyle kullanılabilir
            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            GamerManager gamerManager2 = new GamerManager(new NewEStateGamerValidationManager());

            Gamer gamer = new Gamer()
            {
                Id = 1,
                FirstName = "Şerife",
                LastName = "Yaman",
                BirthYear = 1995,
                NationalityId = "12345"
            };

            gamerManager.Add(gamer);     //oyuncu ekleme

            Campaign campaign = new Campaign()
            {
                Id = 1,
                CampaignName = "Steam İndirimleri"
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);    //kampanya ekleme
            campaignManager.Update(campaign); //kampanya silme
            campaignManager.Delete(campaign); //kampanya güncelleme

            OrderManager orderManager = new OrderManager(new Campaign1TypeManager());
            orderManager.SatısYap(gamer);    //kampanyaya göre satış yapma
        }
    }
}
