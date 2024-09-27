using Common.DTOs;
using Data.Entities;
using Data.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void CreateUser(CreateUserDTO dto)
        {
            User newUser = new User()
            {
                Username = dto.Username,
                Password = dto.Password
            };
            _userRepository.AddUser(newUser);
        }
    }
}
