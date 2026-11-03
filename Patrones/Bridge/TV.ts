import { Dispositivo } from "./Dispositivo";

export class TV implements Dispositivo{
    private estaEncendido = false
    private volumenActual = 10

    encender() : void{
        if (this.estaEncendido){
            console.log("la tv ya esta encendida");
            return
        }
        console.log("Encendiendo la tv");
        this.estaEncendido = true;
    }
    
    apagar() : void{
        if (!this.estaEncendido){
            console.log("la tv ya esta apagada");
            return
        }
        console.log("apagando la tv");
        this.estaEncendido = false;
    }
    
    cambiarVolumen(volumen: number): void {
        if(this.estaEncendido){
            this.volumenActual = volumen
        }
    }
}