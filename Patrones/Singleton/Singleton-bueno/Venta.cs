using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_bueno
{
    public class Venta
    {
        private readonly IAlmacen _almacen;

        public Venta(IAlmacen almacen)
        {
            _almacen = almacen;
        }

        public bool CobrarProducto(int codigo, int cantidad)
        {
            Producto venta = _almacen.BuscarProducto(codigo);
            if (venta == null) return false;
            double total = venta.Precio * cantidad;
            Console.WriteLine($"[CAJA]: Venta realizada con exito por el producto: {venta.Nombre}");
            return true;
        }
    }
}
