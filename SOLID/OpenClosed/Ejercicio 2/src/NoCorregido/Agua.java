package NoCorregido;

public class Agua extends  Bebida{
    
    public Agua(String nombreBebida, double PrecioBase){
        super(nombreBebida, Etiqueta.SIN_IVA, PrecioBase);
    }

    @Override 
    public boolean requiereINE(){
        return false;
    }

    @Override
    public double calcularTotal() {
        return getPrecioBase();
    }

}
