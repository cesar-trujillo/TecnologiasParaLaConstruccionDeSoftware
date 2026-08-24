using System;
using System.Security.Cryptography.X509Certificates;

public class Personaje
{
    private string nombre;
    private int puntosVida;
    private bool estadoVida;

    public Personaje(string Nombre)
    {
        this.Nombre = Nombre;
        PuntosVida = 100;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public int PuntosVida { get => puntosVida; set => puntosVida = value; }
    public bool EstadoVida { get => estadoVida; set => estadoVida = value; }

    public void RecibirDano(int cantidad)
    {
        puntosVida -= cantidad;
        if(PuntosVida < 0)
        {
            System.Console.WriteLine($"{Nombre} recibio daño de {cantidad}, sus puntos de vida son ");
        }
    }
}
