using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1.OCP.Aliens
{
    public class HumungosaurioSupremo : Humungosaurio
    {
        public override string Nombre => "Humungosaurio supremo";
        public override void UsarHabilidad()
        {
            base.UsarHabilidad();
            System.Console.WriteLine($"{Nombre} lanza misiles de sus brazos");
        }
    }
}
