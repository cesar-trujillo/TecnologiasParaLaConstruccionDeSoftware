package Corregido;

public class App {
    public static void main(String[] args) throws Exception {
        Caja caja = new Caja();
        VerificadorEdad edad = new VerificadorEdad();
        GeneradorEtiqueta etiqueta = new GeneradorEtiqueta();
        CalcualdoraDescuento descuento = new CalcualdoraDescuento();

        String[] bebidas = {"agua", "refresco", "tepache", "cerveza"};
        double subTotal = 0;

        for (String bebida : bebidas){
            double precioBebida = caja.calcularPrecio(bebida, 25);
            System.out.println(etiqueta.generarEtiqueta(bebida) + "-> $" + precioBebida + "|requiere INE: " + edad.requiereINE(bebida));

            subTotal += precioBebida;
        }

        System.out.println("Subtotal: " + subTotal);
        System.out.println("descuento de navidad");
        System.out.println("Total" + descuento.aplicarDescuento("descuentoNavidad", subTotal));
    }
}
