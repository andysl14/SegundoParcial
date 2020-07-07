using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SegundoParcial.DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Proyectos> Proyectos { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
        public int TareaId { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\PrimerParcial.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tareas>().HasData(new Tareas { TareaId = 1, Tarea = "Analisis" });
            modelBuilder.Entity<Tareas>().HasData(new Tareas { TareaId = 2, Tarea = "Diseño"});
            modelBuilder.Entity<Tareas>().HasData(new Tareas { TareaId = 3, Tarea = "Desarrollo" });
            modelBuilder.Entity<Tareas>().HasData(new Tareas { TareaId = 4, Tarea = "Prueba" });

        }

    }
}
