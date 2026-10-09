using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_bueno
{
    public class Program
    {
        public static void Main()
        {
            IAlmacen almacenGlobal = AlmacenCentral.Instancia;

            Inventario empleadoInventario = new Inventario(almacenGlobal);
            Venta empleadoVenta = new Venta(almacenGlobal);
            empleadoInventario.RegistrarProducto("Coca", 20.00, 1, 10);
            empleadoInventario.RegistrarProducto("Azucar", 10.00, 2, 4);
            empleadoInventario.RegistrarProducto("bubulubu", 5.00, 3, 34);
            empleadoInventario.RegistrarProducto("Pepsi", 12.00, 4, 10);

            empleadoVenta.CobrarProducto(1, 4);
            empleadoVenta.CobrarProducto(2, 4);
            empleadoVenta.CobrarProducto(3, 18);

            var instancia1 = AlmacenCentral.Instancia;
            var instancia2 = AlmacenCentral.Instancia;

            if(ReferenceEquals(instancia1, instancia2))
            {
                Console.WriteLine("Ambos apuntan a la misma instancia");
            }
        }
    }
}
