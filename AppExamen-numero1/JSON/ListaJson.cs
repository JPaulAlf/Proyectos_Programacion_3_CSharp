using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Examen1.LogiCargo.JSON
{
    [DataContract]
    class ListaJson
    {
        [DataMember]
        public string TipoProducto { set; get; }
        [DataMember]
        public string Descripcion { set; get; }
        [DataMember]
        public double Precio { set; get; }
        [DataMember]
        public double Peso { set; get; }
        [DataMember]
        public double TamanoLargo { set; get; }
        [DataMember]
        public double TamanoAncho { set; get; }
        [DataMember]
        public double TamanoAlto { set; get; }
    }
}
