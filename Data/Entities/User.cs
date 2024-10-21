using Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Nombre de usuario, requerido y único ✓ (unico no se como) 
        [Required]
        public string UserName { get; set; } = string.Empty;

        // Contraseña, al menos 8 caracteres ✓
        [MinLength(8)]
        public string Password { get; set; }

        public Rol Rol { get; set; }
    }
}
