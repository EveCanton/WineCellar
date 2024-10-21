using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Wine
    {
        //no se pone en el DTO se crea automaticamente
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

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
        private int _stock;
        public int Stock
        {
            get => _stock;
            set
            {
                if (value < 0) throw new ArgumentException("El stock no puede ser negativo.");
                _stock = value;
            }
        }
        //No se pone en DTO porque es automatico
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Método para añadir stock
        public void AddStock(int amount)
        {
            if (amount <= 0) throw new ArgumentException("La cantidad a añadir debe ser mayor a 0.");
            Stock += amount;
        }

        // Método para reducir stock
        public void RemoveStock(int amount)
        {
            if (amount <= 0) throw new ArgumentException("La cantidad a reducir debe ser mayor a 0.");
            if (Stock - amount < 0) throw new InvalidOperationException("No hay suficiente stock disponible.");
            Stock -= amount;
        }
    }
}
