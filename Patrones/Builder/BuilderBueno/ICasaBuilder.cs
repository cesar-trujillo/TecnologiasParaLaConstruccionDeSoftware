using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderBueno
{
    public interface ICasaBuilder
    {
        public ICasaBuilder ConPisos(int Pisos);
        public ICasaBuilder ConColor(string Color);
        public ICasaBuilder ConMaterial();
        public ICasaBuilder ConTecho();
        public ICasaBuilder ConGaraje();
        public ICasaBuilder ConJardin();
        public ICasaBuilder ConAlberca();

        public Casa Build();

    }
}
