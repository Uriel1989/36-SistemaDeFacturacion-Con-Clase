using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _36_SistemaDeFacturacion__Con_Clase_
{
    public class Factura
    {

        public List<Factura> MiFactura = new List<Factura>();

        public int CodigoDeFactura { get; set; }
        public string LugarDeEmision { get; set; }
        public int AñoDeEmision { get; set; }
        public decimal GranTotal { get; set; }
        
    }
}
