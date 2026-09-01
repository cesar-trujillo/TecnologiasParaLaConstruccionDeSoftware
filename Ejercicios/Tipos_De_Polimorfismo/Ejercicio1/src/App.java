public class App {
    public static void main(String[] args) throws Exception {
        Caja caja = new Caja();

        MetodoPago tarjeta = new Tarjeta("12345678912345678");
        MetodoPago paypal = new PayPal("usuario@gmail.com");
        MetodoPago contado = new Contado(true);

        caja.cobrar(tarjeta, 500);
        caja.cobrar(paypal, 199);
        caja.cobrar(contado, 100);
    }
}
