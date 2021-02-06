using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public interface IGamerValidateionService
    {
        //oyuncu doğrulama fonksiyonu
        Boolean Validate(Gamer gamer);
    }
}
