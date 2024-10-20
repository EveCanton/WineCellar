﻿using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User? GetUserByUsernameAndPassword(string UserName, string Password);
    }
}
