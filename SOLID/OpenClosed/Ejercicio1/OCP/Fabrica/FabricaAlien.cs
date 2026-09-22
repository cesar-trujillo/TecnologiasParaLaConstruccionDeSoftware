using Ejercicio1.OCP.Aliens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1.OCP.Fabrica
{
    public static class FabricaAlien
    {
        public static IAliens CrearDesdeMuestra(MuestraADN muestra)
        {
            return new CreadorAlien(muestra.Nombre, muestra.Descripcion, muestra.Habilidad);

        }
    }
}
