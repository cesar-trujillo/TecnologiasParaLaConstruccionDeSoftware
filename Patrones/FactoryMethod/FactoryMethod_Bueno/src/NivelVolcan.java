public class NivelVolcan extends Nivel{
    public NivelVolcan(){
        super("volcan infernal");
    }

    @Override 
    public Enemigo crearEnemigo(){
        return new Dragon();
    }
}
