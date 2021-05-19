using DisneyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyAPI.Data
{
    public class DisneyDbContext : DbContext
    {
        public DisneyDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<PersonajesPeliculas> PersonajesPeliculas {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonajesPeliculas>().HasKey(pp => new { pp.PeliculaId, pp.PersonajeId });
            modelBuilder.Entity<PersonajesPeliculas>().HasOne(p => p.Personaje).WithMany(pl => pl.PersonajesPeliculas).HasForeignKey(p=>p.PersonajeId);
            modelBuilder.Entity<PersonajesPeliculas>().HasOne(p => p.Pelicula).WithMany(pl => pl.PersonajesPeliculas).HasForeignKey(p => p.PeliculaId);

            base.OnModelCreating(modelBuilder);

        }


    }
}
