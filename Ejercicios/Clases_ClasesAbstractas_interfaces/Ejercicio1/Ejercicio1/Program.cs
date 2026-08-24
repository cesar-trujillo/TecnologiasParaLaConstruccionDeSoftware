using Ejercicio1;

Guerrero guerrero1 = new Guerrero("Justin");
Mago mago1 = new Mago("Christoper");

System.Console.WriteLine("Duelo");
System.Console.WriteLine($"{mago1.Nombre} vs {guerrero1.Nombre}");

while(mago1.EstadoVida && guerrero1.EstadoVida)
{
    System.Console.WriteLine("1.Gurerrero Ataca a mago");
    System.Console.WriteLine("2. Mago Ataca a guerrero");
    System.Console.WriteLine("3. Mago usa habilidad");

    string? opcion = Console.ReadLine();

    switch(opcion)
        case "1":
}

