using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    internal class Mago : Personaje, IHabilidadEspecial
    {
        public Mago(string nombre) : base(nombre)
        {

        }

        public override void Ataque(Personaje objetivo)
        {
            System.Console.WriteLine($"{nombre} lanzó una bola de fuego a {objetivo}");
            objetivo.RecibirDano(15);
        }

        public void UsarHabilidad()
        {
            PuntosVida += 30;
            if(PuntosVida < 100)
            {
                PuntosVida = 100;
                System.Console.WriteLine($"{nombre} regeneró 30 puntos de vida, su vida actual es {PuntosVida}.");
            }
        }
        
    }
}
