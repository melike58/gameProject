using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
    class UserValidationManager : IUserValidationService
    {
        public bool validate(Gamer gamer)
        {
            if (gamer.dateOfBirth == 2001 && gamer.name == "Melike" && gamer.lastName == "Özdoğan" && gamer.identityNumber == 123456789)
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
