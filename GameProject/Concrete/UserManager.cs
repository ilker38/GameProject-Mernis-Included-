using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserManager : IUserService
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(User gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Eklendi");
            }
            else
            {
                Console.WriteLine("Validateion Failed Please Check Your Information");
                //throw new Exception("Gamer Validation Failed");
            }
            
        }

        public void Delete(User gamer)
        {
            Console.WriteLine("Gamer Successfully Deleted");
        }

        public void Update(User gamer)
        {
            Console.WriteLine("Gamer Successfully Updated");
        }
    }
}
