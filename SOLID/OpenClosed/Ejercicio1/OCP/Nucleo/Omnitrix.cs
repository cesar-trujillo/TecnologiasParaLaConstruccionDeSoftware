using Ejercicio1.OCP.Aliens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1.OCP.Nucleo
{
    public class Omnitrix
    {
        public IAliens? AlienActual { get; private set; }
        public bool EstaTransformado => AlienActual != null;
        
        public void Transformar(IAliens alien)
        {
            AlienActual = alien;
            System.Console.WriteLine($"Transformacon Completada. Ahora eres {AlienActual.Nombre}");
        }

        public void Destransformar(IAliens alien)
        {
            if (AlienActual != null)
            {
                System.Console.WriteLine($"Timeout. {alien.Nombre} ahora es Ben.");
                AlienActual = null;
            }
        }
    }
}
