﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1998 && gamer.FirstName == "Fırat" && gamer.LastName == "İke" && gamer.IdentityNumber == 123456789) 
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
