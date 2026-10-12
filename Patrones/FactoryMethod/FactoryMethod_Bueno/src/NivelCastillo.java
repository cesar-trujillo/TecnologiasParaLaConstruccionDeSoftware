public class NivelCastillo extends Nivel{
    public NivelCastillo(){
        super("castillo embrujado");
    }

    @Override 
    public Enemigo crearEnemigo(){
        return new Esqueleto();
    }
}
