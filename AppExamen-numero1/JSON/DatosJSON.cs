using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Examen1.LogiCargo.JSON
{
    [DataContract]
    class DatosJSON
    {
        [DataMember]
        public string
        NombreAgenciaAduanal
        { set; get; }
        [DataMember]
        public string Cliente
        { set; get; }
        [DataMember]
        public List<ListaJson> Lista
        { set; get; }
    }

}
