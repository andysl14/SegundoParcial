using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SegundoParcial.Entidades
{
    public class ProyectosDetalle
    {
        [Key]
        public int Id { get; set; }
        public int TipoId { get; set; }
        public string Requerimiento { get; set; }
        public int Tiempo { get; set; }

        public ProyectosDetalle(int tipoId, string requerimiento, int tiempo)
        {
            Id = 0;
            TipoId = tipoId;
            Requerimiento = requerimiento;
            Tiempo = tiempo;

        }
    }
}
