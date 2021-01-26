using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Examen1.LogiCargo.Util
{
    class JSONGenericObject<T>
    {
        public static T JSonToObject(string pDatos)
        {

            //Crear serializador
            DataContractJsonSerializer oDataContractJsonSerializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream(System.Text.ASCIIEncoding.UTF8.GetBytes(pDatos));

            // Convertirlo en Objetos
            T @object = (T)oDataContractJsonSerializer.ReadObject(ms);

            return @object;

        }


    }
}
