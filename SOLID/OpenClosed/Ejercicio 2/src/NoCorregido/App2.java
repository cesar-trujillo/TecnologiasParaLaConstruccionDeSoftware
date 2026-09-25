package NoCorregido;

public class App2 {
    public static void main(String [] args) throws Exception {
        Bebida[] bebidas = {
            new Agua("CIEL", 20),
            new Refresco("coca", 25),
            new Cerveza("coronita", 30)
        };

        Caja caja = new Caja();
        caja.cobrar(bebidas, new DescuentoNavidad(), 100);
    }
}
