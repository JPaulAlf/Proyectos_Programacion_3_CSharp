using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploExcepciones
{
    class LongitudNombreException : ApplicationException
    {
        public LongitudNombreException()
            : base()
        {

            // aqui se puede guardar el error en una bitacora
        }

        public LongitudNombreException(string mensaje)
            : base(mensaje)
        {
            // aqui se puede guardar el error en una bitacora
        }
    }
}
