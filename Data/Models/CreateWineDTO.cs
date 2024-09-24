using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class CreateWineDTO
    {
        // El nombre del vino, requerido ✓
        [Required]
        public string Name { get; set; } = string.Empty;

        // Variedad del vino (ej: Cabernet Sauvignon) ✓
        public string Variety { get; set; } = string.Empty;

        // Año de cosecha, debe ser un valor válido ✓
        [Range(1860, 2024, ErrorMessage = "El año de cosecha debe estar entre 1860 y el año actual.")]
        public int Year { get; set; }

        // Región de origen (ej: Mendoza, La Rioja) ✓
        public string Region { get; set; } = string.Empty;

        // Cantidad disponible en stock, debe ser mayor o igual a 0 ✓
        [Range(0, int.MaxValue, ErrorMessage = "El stock debe ser mayor o igual a 0.")]
        public int Stock { get; set; }

    }
}
