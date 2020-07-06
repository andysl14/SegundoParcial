using System;
using System.Collections.Generic;
using System.Text;

namespace SegundoParcial.BLL
{
    public class Utilidades
    {
        public static int Toint(string valor)
        {
            int retorno = 0;

            int.TryParse(valor, out retorno);

            return retorno;
        }
    }
}
