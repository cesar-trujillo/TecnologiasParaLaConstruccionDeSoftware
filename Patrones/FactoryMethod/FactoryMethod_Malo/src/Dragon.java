public class Dragon extends Enemigo{
    public Dragon(){
        super("Dragon", 200, 60);
    }

    public void atacar(){
        System.out.println("El dragon escupe su fuegoo y te quita" + this.ataque + " de vida");
    }
}
