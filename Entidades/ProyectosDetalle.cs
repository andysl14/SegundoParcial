using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SegundoParcial.Entidades
{
    public class ProyectosDetalle
    {
        [Key]
        public int Id { get; set; }
        public int TipoId { get; set; }
        public int ProyectoId { get; set; }
        public int TareaId { get; set;}
        public string Requerimiento { get; set; }
        public int Tiempo { get; set; }


        [ForeignKey("TareaId")]
        public Tareas Tarea { get; set; } = new Tareas();

    }
}
