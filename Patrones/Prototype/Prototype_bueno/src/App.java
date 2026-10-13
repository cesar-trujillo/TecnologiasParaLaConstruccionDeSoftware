import java.util.ArrayList;
import java.util.List;

public class App {
    public static void main(String[] args) throws Exception {
        NucleoEnergia nucleoOriginal = NucleoEnergia.crearInicial();
        Motor motorOriginal = new Motor("Motor principal", 500, nucleoOriginal);
        Nave original = new Nave("Interceptor", 100, motorOriginal, 
            new ArrayList<>(List.of(new Arma("Laser", 60), new Arma("Misil", 120))),
            new Tripulacion("Ordis", "777")
        );

        List<Nave> naves = new ArrayList<>();
        naves.add(original);

        Nave clon1 = original.clonar();
        Nave clon2 = original.clonar();
        Nave clon3 = original.clonar();

        naves.add(clon1); naves.add(clon2); naves.add(clon3);
        muestraTodas(naves, "Estado Inicial");

        clon1.setEscudo(150);
        muestraTodas(naves, "cambiando escudo en clon1");
    }

    public static void muestraTodas(List<Nave> naves, String titulo){
        System.out.println("\n " + titulo + " ===");
        for(int i = 0; i < naves.size(); i++) naves.get(i).mostrar(i);
    }
}
