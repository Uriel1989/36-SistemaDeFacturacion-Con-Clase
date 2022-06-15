using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _36_SistemaDeFacturacion__Con_Clase_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Sistema de Facturacion.");

            

            Console.WriteLine("Ingrese el nombre de la razon social:");
            string RazonSocial = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese el numero de CUIT: ");
            int CUIT = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del responsable de compras:");
            string ResponsableDeCompras = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese el Codigo de Factura: ");
            int CodigoDeFactura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del lugar de emision: ");
            string LugarDeEmision = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese el año de emision: ");
            int AñoDeEmision = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del producto: ");
            string NombreDelProducto = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del producto: ");
            int PrecioUnitario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad: ");
            int Cantidad = Convert.ToInt32(Console.ReadLine());

            Cliente Cliente1 = new Cliente
            {
                RazonSocial = RazonSocial,
                CUIT = CUIT,
                ResponsableDeCompras = ResponsableDeCompras,
             };
            

            Factura Factura1 = new Factura
            {
                CodigoDeFactura = CodigoDeFactura,
                LugarDeEmision = LugarDeEmision,
                AñoDeEmision= AñoDeEmision,   
                GranTotal = Cantidad * PrecioUnitario,
            };

            Producto Producto1 = new Producto
            {
                NombreDelProducto= NombreDelProducto,
                PrecioUnitario= PrecioUnitario,
                Cantidad= Cantidad,
            };

            Console.WriteLine("Razon Social: " + RazonSocial + Environment.NewLine 
                + "CUIT: " + CUIT + Environment.NewLine + "Responsable de Compras: " + ResponsableDeCompras + 
                Environment.NewLine + "Codigo de Factura: " + CodigoDeFactura + Environment.NewLine + 
                "Lugar de Emision: " + LugarDeEmision + Environment.NewLine + "Año de Emision: " + AñoDeEmision +
                "Nombre del Producto: "  + NombreDelProducto + Environment.NewLine + "Precio Unitario: " + PrecioUnitario +
                "Cantidad"  +Environment.NewLine + Cantidad + Environment.NewLine + "Subtotal: "  + Producto1.Subtotal(Cantidad, PrecioUnitario) + 
                Environment.NewLine + "Gran Total: " + Factura1.GranTotal);

            Console.ReadKey();
        }
    }
}
