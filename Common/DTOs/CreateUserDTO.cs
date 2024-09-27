using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs
{
    public class CreateUserDTO
    {
        // Nombre de usuario, requerido y único ✓ (unico no se como) 
        [Required]
        public string Username { get; set; } = string.Empty;

        // Contraseña, al menos 8 caracteres ✓
        [MinLength(8)]
        public string Password { get; set; }
    }
}
