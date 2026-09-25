package NoCorregido;

public class Refresco extends Bebida {

    public Refresco(String nombreBebida, double PrecioBase){
        super(nombreBebida, Etiqueta.CON_IVA, PrecioBase);
    }

    @Override 
    public boolean requiereINE(){
        return true;
    }

    @Override
    public double calcularTotal() {
        return getPrecioBase() * (1 + IVA);
    }
}
