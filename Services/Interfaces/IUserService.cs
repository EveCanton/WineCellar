using Common.DTOs;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUserService //interfaz para el servicio donde defino los métodos
    {
        //Crear un usuario.
        void CreateUser(CreateUserDTO dto);
        User? ValidateUser(AuthenticationDTO authDto);
    }
}
