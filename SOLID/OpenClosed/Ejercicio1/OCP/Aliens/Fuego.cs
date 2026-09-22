using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Ejercicio1.OCP.Aliens
{
    public class Fuego : IAliens
    {
        public virtual string Nombre => "Fuego";
        public virtual string Descripcion => "Pyronita | Ser compuesto por plasma y rocas volcanicas";
        public virtual void UsarHabilidad()
        {
            System.Console.WriteLine($"{Nombre} lanza bolas de fuego");
        }
    }
}
