using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class WineCellarContext : DbContext //lo obtenemos gracias a EntityFrameworkCore
    {
        //crea las tablas
        public DbSet<User> Users { get; set; }
        public DbSet <Wine> Wines { get; set; }
        public DbSet<Cata> Catas { get; set; }

        public WineCellarContext(DbContextOptions<WineCellarContext> options) : base(options) //Acá estamos llamando al constructor de DbContext que es el que acepta las opciones
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //ésto si es esencial para que por lo menos se cree la tabla vacía
        {

            User karen = new User()
            {
                Id = 1,
                UserName = "karenbailapiola@gmail.com",
                Password = "Pa$$w0rd",
                Rol = Data.Enum.Rol.Admin,
            };

            User Juan = new User()
            {
                Id = 2,
                UserName = "juanperez@gmail.com",
                Password = "SecureP@ss",
                Rol = Data.Enum.Rol.Admin,
            };

            Wine cabernetSauvignon = new Wine()
            {
                Id = 1,
                Name = "Cabernet Sauvignon",
                Variety = "Cabernet Sauvignon",
                Year = 2018,
                Region = "Mendoza",
                Stock = 50,
                CreatedAt = DateTime.UtcNow
            };

            Wine malbec = new Wine()
            {
                Id = 2,
                Name = "Malbec",
                Variety = "Malbec",
                Year = 2020,
                Region = "Mendoza",
                Stock = 30,
                CreatedAt = DateTime.UtcNow
            };


            modelBuilder.Entity<User>().HasData(karen, Juan);
            modelBuilder.Entity<Wine>().HasData(malbec, cabernetSauvignon);
            

            modelBuilder.Entity<Cata>()
                .HasMany(c => c.Wines)
                .WithMany();


            base.OnModelCreating(modelBuilder); //ésto también es esencial
        }

    }
}
