using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1.OCP.Aliens
{
    public class CuatroBrazos : IAliens
    {
        public virtual string Nombre => "Cuatro Brazos";
        public virtual string Descripcion => "Tetramand | posee super fuerza, piel blindada y cuatro brazos";
        public virtual void UsarHabilidad()
        {
            System.Console.WriteLine($"{Nombre} ataca con aplauso sonico");
        }
    }
}
