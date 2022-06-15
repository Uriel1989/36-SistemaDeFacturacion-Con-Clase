using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _36_SistemaDeFacturacion__Con_Clase_
{
    public class Producto
    {
        public string NombreDelProducto { get; set; }

        public decimal PrecioUnitario { get; set; }

        public int Cantidad { get; set; }

        public decimal Subtotal(decimal PrecioUnitario, decimal Cantidad)
        {
            return PrecioUnitario * Cantidad;
        }
    }
}
