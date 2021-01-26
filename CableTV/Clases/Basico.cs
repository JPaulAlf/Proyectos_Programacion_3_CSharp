using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.CableTV.Clases
{
    public class Basico : Paquete
    {
        public override string Descripcion { get; }

        public override float PorcentajeCosto { get; } = 0.055f;

        public override float PorcentajeImpuesto { get; } = 0.13f;
    }
}
