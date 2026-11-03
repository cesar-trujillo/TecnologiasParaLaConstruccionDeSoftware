public class Box : IComponente
{
    private readonly List<IComponente> _children = new();
    public string Name {get;}

    public Box(string name) => Name = name;

    public void Add(IComponente componente) => _children.Add(componente);
    public void Remove(IComponente componente) => _children.Remove(componente);

    public decimal CalcualtePrice() => _children.Sum(child => child.CalcualtePrice());

    public void Display(int indent = 0)
    {
        System.Console.WriteLine(new string ('-', indent) + $" + [Caja] {Name}");
        foreach(var child in _children)
        {
            child.Display(indent + 2);
        }
    }
}