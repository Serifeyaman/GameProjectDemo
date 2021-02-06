using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class GamerValidationManager : IGamerValidateionService
    {
        //mernis gibi bir doğrulama olsun
        public Boolean Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1995 && gamer.FirstName == "Şerife" && gamer.LastName == "Yaman" && gamer.NationalityId == "12345")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
