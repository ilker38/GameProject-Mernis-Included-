using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference1;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User gamer)
        {
            return true;
        }
    }
}
