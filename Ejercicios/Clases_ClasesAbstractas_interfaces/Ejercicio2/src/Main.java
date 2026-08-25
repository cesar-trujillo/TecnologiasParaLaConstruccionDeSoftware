public class Main {
    public static void main(String[] args) {
        
        Piston miPiston = new Piston();
        Puerta miPuerta = new Puerta();
        Lampara miLampara = new Lampara();
        BloqueMusical mBloqueMusical = new BloqueMusical();

        System.out.println("Se activa la palanca");
        miPiston.activar();
        miPuerta.activar();
        miLampara.activar();
        mBloqueMusical.activar();

        System.out.println("se desactiva la palanca");
        miPiston.desactivar();
        miPuerta.desactivar();
        miLampara.desactivar();
        mBloqueMusical.desactivar();


        Zombie miZombie = new Zombie();
        Esqueleto miEsqueleto = new Esqueleto();

        miZombie.quemarEnLava();
        miEsqueleto.quemarEnLava();

        miZombie.atacar();
        miEsqueleto.atacar();

    }
}
