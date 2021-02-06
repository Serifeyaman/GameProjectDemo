using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class GamerManager : IGamerService
    {
        //validation service kullanmak için
        IGamerValidateionService _gamerValidationService;
        public GamerManager(IGamerValidateionService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }
        //operasyonların simülasyonu 
        public void Add(Gamer gamer)
        {
            //doğrulamadan true gelirse kaydet
            if (_gamerValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " Kaydedildi");
            }
            else
            {
                Console.WriteLine("Geçersiz Kullanıcı!!! Kayıt Başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Silindi");
        }  

        public void Update(Gamer gamer)
        {
            Console.WriteLine(" Kayıt Güncellendi");
        }
    }
}
