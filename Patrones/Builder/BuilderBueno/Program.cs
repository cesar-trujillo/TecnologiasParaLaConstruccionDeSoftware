using BuilderBueno;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Casa personalizada = new CasaBuilder()
        .ConAlberca()
        .ConColor("Azul")
        .ConTecho()
        .ConMaterial()
        .Build();

        Casa personalizada1 = new CasaBuilderModerna()
        .ConPisos(2)
        .ConColor("Amarillo")
        .ConTecho()
        .ConMaterial()
        .Build();

        Director director = new Director(new CasaBuilder());
        Director director1 = new Director(new CasaBuilderModerna());

        Casa basica = director.ConstruirCasaBasica();
        Casa delujo = director.ConstruirCasaDeLujo();
        Casa menosBasica = director1.ConstruirCasaDeLujo();

        personalizada.Mostrar();
        personalizada1.Mostrar();
        basica.Mostrar();
        delujo.Mostrar();
        menosBasica.Mostrar();
    }
}