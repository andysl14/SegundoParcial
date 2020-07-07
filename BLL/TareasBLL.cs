using SegundoParcial.DAL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SegundoParcial.BLL
{
    public class TareasBLL
    {
        

        public static Tareas Buscar(int id)
        {
            Tareas tareas;
            Contexto contexto = new Contexto();

            try
            {
                tareas = contexto.Tareas.Find(id);

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
        }
    }
}
