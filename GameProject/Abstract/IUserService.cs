using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserService
    {
        void Add(User gamer);
        void Update(User gamer);
        void Delete(User gamer);
    }
}
