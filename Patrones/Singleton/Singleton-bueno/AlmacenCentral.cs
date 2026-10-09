using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_bueno
{
    public class AlmacenCentral : IAlmacen
    {
        private List<Producto> _Productos;
        private readonly Lazy<AlmacenCentral> _instancia =
            new Lazy<AlmacenCentral>(() => new AlmacenCentral());

         public static AlmacenCentral Instancia => _instancia.Value;

        private AlmacenCentral()
        {
            Console.WriteLine("creando el almacen");
            _productos = new List<Producto>();
        }

        public List<Producto> ObtenerProductos() => _productos;

        public Producto BuscarProducto(int codigo) => _productos.FirstOrDefault(p => p.codigo == codigo);

        public bool AgregarProducto(Producto producto)
        {
            if(BuscarProducto(producto.Codigo) == null)
            {
                _productos.Add(producto);
                return true;
            }
            return false;
        }
    }
}
