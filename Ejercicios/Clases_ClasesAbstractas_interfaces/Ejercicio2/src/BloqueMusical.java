public class BloqueMusical implements ActivablePorRedstone {

    @Override
    public void activar() {
        System.out.println("blouque recibe señal y se produce musica");
    }

    @Override
    public void desactivar() {
        System.out.println("bloque recibe señal y deja de reproducir");
    }
    
}
