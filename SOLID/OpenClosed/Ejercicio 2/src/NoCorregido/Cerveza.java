package NoCorregido;

public class Cerveza extends Bebida {

    private final double IEPS = 1.25;
    
    public Cerveza(String nombreBebida, double PrecioBase){
        super(nombreBebida, Etiqueta.CON_IEPS, PrecioBase);
    }

    @Override 
    public boolean requiereINE(){
        return true;
    }

    @Override
    public double calcularTotal() {
        return getPrecioBase() * (1 * IVA) * IEPS;
    }
}
