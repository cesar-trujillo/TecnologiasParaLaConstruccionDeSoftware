public class Program
{
    public static void Main()
    {
        IComponente ram = new Producto("Memoria RAM", 80);
        IComponente cpu = new Producto("CPU", 220m);
        IComponente Mouse = new Producto("Mouse", 25m);
        IComponente keybd = new Producto("Teclado Inalambrico", 599);
        IComponente cableHDMI = new Producto("cable HDMI", 449);

        Box pcBox = new Box("PC Box");
        Box peripherals = new Box("perifericos");
        Box mainOrder = new Box("Caja principla");

        pcBox.Add(ram);
        pcBox.Add(cpu);

        peripherals.Add(Mouse);
        peripherals.Add(keybd);

        mainOrder.Add(cableHDMI);

        mainOrder.Add(pcBox);
        mainOrder.Add(peripherals);

        System.Console.WriteLine("Calculo de cajas individuales");
        System.Console.WriteLine($"Total de pc: {pcBox.CalcualtePrice()}");
        System.Console.WriteLine($"total perifericos: {peripherals.CalcualtePrice()}");
        System.Console.WriteLine("calculo total");
        System.Console.WriteLine($"total: {mainOrder.CalcualtePrice()}");
        mainOrder.Display();
    }
}