using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    internal class Guerrero : Personaje
    {
        public Guerrero(string nombre) : base(nombre) 
        { 
            
        }

        public override void Ataque(Personaje objetivo)
        {
            System.Console.WriteLine($"{nombre} ataca con la espada a {objetivo.nombre}");
            objetivo.RecibirDano(30);
        }
    }
}
