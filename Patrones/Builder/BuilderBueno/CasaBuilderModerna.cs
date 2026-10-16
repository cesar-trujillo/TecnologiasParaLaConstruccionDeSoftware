using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderBueno
{
    public class CasaBuilderModerna : ICasaBuilder
    {
        private Casa _casa = new Casa();

        public ICasaBuilder ConPisos(int Pisos)
        {
            _casa.Pisos = Pisos;
            return this;
        }

        public ICasaBuilder ConColor(string Color)
        {
            _casa.Color = Color;
            return this;
        }

        public ICasaBuilder ConMaterial(string Material)
        {
            _casa.Material = "Concreto";
            return this;
        }

        public ICasaBuilder ConTecho(string Techo)
        {
            _casa.TieneTecho = true;
            _casa.TipoTecho = "De policarbonato";
            return this;
        }

        public ICasaBuilder ConGaraje()
        {
            _casa.TieneGaraje = true;
            return this;
        }

        public ICasaBuilder ConJardin()
        {
            _casa.Jardin = true;
            return this;
        }

        public Casa Build()
        {
            Casa resultado = _casa;
            _casa = new Casa();
            return resultado;
        }
    }
}
