public class Contado implements MetodoPago {
    boolean estadoBilletes;

    public Contado(boolean estadoBilletes){
        this.estadoBilletes = estadoBilletes;
    }

    @Override
    public boolean validar(){
        if(estadoBilletes){
            return true;
        }
        return false;
    }

    @Override
    public void pagar(double monto){
        System.out.println("El billete está en buen estado");
    }
}
