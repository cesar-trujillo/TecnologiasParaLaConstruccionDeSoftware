import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
        int opcion = -1;

        while (opcion != 0) {
            System.out.println("1.Bosque oscuro");
            System.out.println("2.Castilo Embrujado");
            System.out.println("3.Volcan Infernal");
            System.out.println("0.Salir");
            System.out.println("Elige un nivel");
            opcion = sc.nextInt();

            Nivel nivel = null;
            switch (opcion) {
                case 1:
                    nivel = new NivelBosque();
                    
                    break;

                case 2:
                    nivel = new NivelCastillo();

                    break;

                case 3:
                    nivel = new NivelVolcan();
                    
                    break; 
                
                case 0:
                    break;

                default:
                    System.out.println("opcion invalida");
                    break;
            }

            if (nivel != null){
                nivel.jugar();
            }
        }

        sc.close();
    }
}
