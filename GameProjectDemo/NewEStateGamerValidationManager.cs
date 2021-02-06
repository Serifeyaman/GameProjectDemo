using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class NewEStateGamerValidationManager : IGamerValidateionService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
