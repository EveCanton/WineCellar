using Data.Entities;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> Users;

        public UserRepository()
        {
            Users = new List<User>();

            User user1 = new User()
            {
                Id = 1,
                Username = "Test",
                Password = "password"
            };
            Users.Add(user1);

            User user2 = new User()
            {
                Id = 2,
                Username = "Test2",
                Password = "password2"
            };
            Users.Add(user2);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }
   

    }
    
}
