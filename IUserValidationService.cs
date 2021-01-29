using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer); //UserValidationManager clasında true ve false döndüreceğimiz için void yerine bool yazıyoruz
    }
}
