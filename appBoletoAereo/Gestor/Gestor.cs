using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.WinForms.Boleto.Gestor
{
    class Gestor
    {
        private Clases.Usuario _Usuario;
        public Gestor(Clases.Usuario pUsuario)
        {
            _Usuario = pUsuario;
        }
        public double GetTax()
        {
            return _Usuario._Boleto.Tax();
        }
        public double GetTotal()
        {
            return _Usuario._Boleto.Total();
        }
        public double GetMonto()
        {
            return _Usuario._Boleto.Monto();
        }
        public void SalvarXML()
        {
            string xml = _Usuario.ToString();
            Clases.XML.CrearArchivoXML(xml);
        }

    }
}
