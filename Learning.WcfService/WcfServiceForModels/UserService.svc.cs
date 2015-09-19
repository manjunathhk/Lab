﻿using Learning.WcfService.Models;

namespace Learning.WcfService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        public string SaveUser(User user)
        {
            return "User is saved";
        }

        public User GetUserInformation()
        {
            return new User { Username = "Username", Password = "Password" };
        }
    }
}
