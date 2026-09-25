package NoCorregido;

public class SinDescuento implements Descuento{

    @Override
    public double aplicar(double total) {
        return total;
    }

    @Override
    public String getDescripcion() {
        return "sin descuento";
    }
    
}
