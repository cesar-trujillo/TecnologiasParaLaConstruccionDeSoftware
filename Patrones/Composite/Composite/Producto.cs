public class Producto : IComponente
{
    private readonly decimal _price;
    public string Name {get;}

    public Producto(string name, decimal price)
    {
        Name = name; 
        _price = price;
    }

    public decimal CalcualtePrice() => _price;
    public void Display(int indent)
    {
        System.Console.WriteLine(new string ('-', indent) + $"{Name} (${_price})");
    }
}