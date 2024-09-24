using Data.Entities;
using Data.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {

        private static List<User> users = new List<User>
    {
        new User { Id = 1, Username = "Matias", Password = "usuario" },
        new User { Id = 2, Username = "Gustavo", Password = "usuario" }
    };

        public List<User> GetUsers()
        {
            return users;
        }
        public User CreateUser(CreateUserDTO dto)
        {
            User newUser = new User()
            {
                Username = dto.Username,
                Password = dto.Password
            };
            users.Add(newUser);
            return newUser;
        }
    }
}
