using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderBueno
{
    public class Casa
    {
        public Casa()
        {

        }

        public int Pisos {  get; set; }
        public string Color { get; set; } = "Sin definir";
        public string Material { get; set; } = "Sin definir";
        public bool TieneTecho { get; set; }
        public string TipoTecho { get; set; } = "No tiene";
        public bool TieneGaraje { get; set; }
        public bool Jardin { get; set; }
        public bool TieneAlberca { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("Micasa tiene: ");
            Console.WriteLine($"Casa tiene {Pisos} piso(s), es de color {Color}");
            Console.WriteLine($"Casa es de {Material}");
            Console.WriteLine($"Casa {TieneTecho} y es de {TipoTecho}");
            Console.WriteLine($"Casa con garaje {TieneGaraje}");
            Console.WriteLine($"Casa tiene jardin {Jardin}");
            Console.WriteLine($"Casa tiene alberca {TieneAlberca}\n");
        }
    }
}
