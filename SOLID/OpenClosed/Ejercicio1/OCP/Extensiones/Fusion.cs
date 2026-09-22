using Ejercicio1.OCP.Aliens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1.OCP.Extensiones
{
    public class Fusion<TAlienA,TAlienB> : IAliens 
        where TAlienA : IAliens, new()
        where TAlienB : IAliens, new()
    {
        private readonly TAlienA _alienA = new();
        private readonly TAlienB _alienB = new();

        public string Nombre => $"Fusion {_alienA.Nombre} + {_alienB.Nombre}";
        public string Descripcion => $" Habilidades combinadas de {_alienA.Nombre} y {_alienB.Nombre}";

        public void UsarHabilidad()
        {
            System.Console.WriteLine($" activa ambas mitades de ADN fusionando:");
            _alienA.UsarHabilidad();
            _alienB.UsarHabilidad();
        }
    }
}
