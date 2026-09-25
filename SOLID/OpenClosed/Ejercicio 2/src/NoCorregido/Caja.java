package NoCorregido;

public class Caja {
    double subTotal = 0;

    public void cobrar(Bebida[] bebidas, Descuento descuento, double efectivo){
        double subTotal = 0;
        for(Bebida bebida : bebidas){
            System.out.println(bebida.getEtiqueta() + " $" + bebida.calcularTotal());
            if(bebida.requiereINE()){
                System.out.println(" Requiere INE");
            }
            subTotal += bebida.calcularTotal();
        }

        double total = descuento.aplicar(subTotal);
        if(efectivo < total){
            System.out.println("efectivo insuficiente");
            return;
        }

        System.out.println("subtotal: " + subTotal);
        System.out.println("Descuento: " + descuento.getDescripcion());
        System.out.println("Total: " + total);
        System.out.println("Cambio: " + (efectivo - total));
    }
}
