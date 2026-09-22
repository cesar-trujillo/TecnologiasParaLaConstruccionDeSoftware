using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1.OCP.Aliens
{
    public interface IAliens
    {
        public string Nombre { get; }
        public string Descripcion { get; }
        public void UsarHabilidad();

    }
}
