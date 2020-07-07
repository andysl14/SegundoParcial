﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SegundoParcial.DAL;

namespace SegundoParcial.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200707025254_Migracion_PerdidaDeDatos")]
    partial class Migracion_PerdidaDeDatos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("SegundoParcial.Entidades.Proyectos", b =>
                {
                    b.Property<int>("ProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.HasKey("ProyectoId");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("SegundoParcial.Entidades.ProyectosDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Requerimiento")
                        .HasColumnType("TEXT");

                    b.Property<int>("TareaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tiempo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoId");

                    b.HasIndex("TareaId");

                    b.ToTable("ProyectosDetalle");
                });

            modelBuilder.Entity("SegundoParcial.Entidades.Tareas", b =>
                {
                    b.Property<int>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tarea")
                        .HasColumnType("TEXT");

                    b.HasKey("TareaId");

                    b.ToTable("Tareas");

                    b.HasData(
                        new
                        {
                            TareaId = 1,
                            Tarea = "Analisis"
                        },
                        new
                        {
                            TareaId = 2,
                            Tarea = "Dise;o"
                        },
                        new
                        {
                            TareaId = 3,
                            Tarea = "Desarrollo"
                        },
                        new
                        {
                            TareaId = 4,
                            Tarea = "Prueba"
                        });
                });

            modelBuilder.Entity("SegundoParcial.Entidades.ProyectosDetalle", b =>
                {
                    b.HasOne("SegundoParcial.Entidades.Proyectos", null)
                        .WithMany("Detalle")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SegundoParcial.Entidades.Tareas", "Tarea")
                        .WithMany()
                        .HasForeignKey("TareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}