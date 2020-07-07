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
            Tareas tarea;
            Contexto contexto = new Contexto();

            try
            {
                tarea = contexto.Tareas.Find(id);

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tarea;
        }

        public static List<Tareas> GetTareas()
        {
            List<Tareas> lista = new List<Tareas>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Tareas.ToList();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
