using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.CableTV.Clases
{
    public class Deportivo : Paquete
    {
        public override string Descripcion { get;  }

        public override float PorcentajeCosto { get; } = 0.088f;

        public override float PorcentajeImpuesto { get; } = 0.15f;
    }
}
