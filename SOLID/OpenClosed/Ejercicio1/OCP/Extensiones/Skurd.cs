using Ejercicio1.OCP.Aliens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1.OCP.Extensiones
{
    public class Skurd
    {
        private readonly IAliens _alienBase;
        private readonly IAliens _alienDonador;

        public Skurd( IAliens alienBase, IAliens alienDonador)
        {
            _alienBase = alienBase;
            _alienDonador = alienDonador;
        }

        public string Nombre => $"{_alienBase.Nombre} + Skurd({_alienDonador.Nombre})";
        public string Descripcion => $"{_alienBase.Descripcion} con las habilidades de {_alienDonador.Descripcion}";

        public void UsarHabilidad()
        {
            _alienBase.UsarHabilidad();
            System.Console.WriteLine("Skurd le presta las habilidades de");
            _alienDonador.UsarHabilidad();
        }
    }
}
