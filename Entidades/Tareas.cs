﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SegundoParcial.Entidades
{
    public class Tareas
    {
        [Key]
        public int TareaId { get; set; }
        public string Tarea { get; set; }

    }
}
