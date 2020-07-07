﻿using Microsoft.EntityFrameworkCore;
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

    }
}
