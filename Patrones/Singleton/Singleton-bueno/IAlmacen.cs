using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_bueno
{
    public interface IAlmacen
    {
        List<Producto> ObtenerProductos();
        Producto BuscarProducto(int codigo);

        void AgregarProducto(Producto producto);


    }
}
