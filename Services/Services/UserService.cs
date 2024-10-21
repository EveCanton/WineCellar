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
                UserName = dto.Username,
                Password = dto.Password,
                Rol = Data.Enum.Rol.User
            };
            _userRepository.AddUser(newUser);
        }

        public User? ValidateUser(AuthenticationDTO authDTO)
        {
            // Usa el método heredado del repositorio para validar el usuario.
            return _userRepository.GetUserByUsernameAndPassword(authDTO.UserName, authDTO.Password);
        }
    }
}
