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

        private readonly WineCellarContext _context;

        // Inyectamos el DbContext en el constructor
        public UserRepository(WineCellarContext context)
        {
            _context = context;
        }

        // Método para agregar un usuario a la base de datos
        public void AddUser(User user)
        {
             _context.Users.AddAsync(user);
             _context.SaveChangesAsync(); // Guardar los cambios en la base de datos
        }

        public User? GetUserByUsernameAndPassword(string username, string password)
        {
            return _context.Users.FirstOrDefault(p => p.UserName == username && p.Password == password);
        }

    }
    
}
