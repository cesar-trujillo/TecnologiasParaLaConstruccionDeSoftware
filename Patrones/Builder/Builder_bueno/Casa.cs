using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_bueno
{
    public class Casa
    {
        

        public int Pisos { get; set; }
        public string Color { get; set; }
        public bool TieneTecho { get; set; }
        public bool TieneGaraje { get; set; }
        public bool TieneAlberca { get; set; }
        public bool TieneJardin { get; set; }

        public Casa(int pisos, string color, bool tieneTecho, bool tieneGaraje, bool tieneAlberca, bool tieneJardin)
        {
            Pisos = pisos;
            Color = color;
            TieneTecho = tieneTecho;
            TieneGaraje = tieneGaraje;
            TieneAlberca = tieneAlberca;
            TieneJardin = tieneJardin;

            
        }
        public Casa(int pisos): this(pisos, "Blanco") { }
        public Casa(int pisos, string color) : this(pisos, "Blanco", true) { }
        public Casa(int pisos, string color, bool TieneTecho) : this(pisos, "Blanco", true, true) { }
        public Casa(int pisos, string color, bool TieneTecho, bool tieneGaraje) : this(pisos, "Blanco", true, true, true) { }
        public Casa(int pisos, string color, bool TieneTecho, bool tieneGaraje, bool TieneAlberca) : this(pisos, "Blanco", true, true, true, true) { }
        public Casa(int pisos, string color, bool TieneTecho, bool tieneGaraje, bool TieneAlberca, bool TieneJardin) : this(pisos, "Blanco", true, true, true, true, true) { }


        public decimal CalcularCosto()
        {
            decimal costo = 500000m * Pisos;
            if (TieneTecho) costo += 100000m;
            if (TieneGaraje) costo += 400000m;
            if (TieneAlberca) costo += 110000m;
            if (TieneJardin) costo += 130000m;
            return costo;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Casa con {Pisos} pisos | Color {Color}");
            Console.WriteLine($"Techo {TieneTecho} | Garaje {TieneGaraje} | Alberca {TieneAlberca} | Jardin {TieneJardin}");
            Console.WriteLine($"Costo {CalcularCosto}:c");
        }
    }
}
