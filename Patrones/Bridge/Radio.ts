import { Dispositivo } from "./Dispositivo";

export class Radio implements Dispositivo{
    private estaEncendido = false
    private volumenActual = 10

    encender() : void{
        if (this.estaEncendido){
            console.log("la radio ya esta encendida");
            return
        }
        console.log("Encendiendo la radio");
        this.estaEncendido = true;
    }
    
    apagar() : void{
        if (!this.estaEncendido){
            console.log("la radio ya esta apagada");
            return
        }
        console.log("apagando la radio");
        this.estaEncendido = false;
    }
    
    cambiarVolumen(volumen: number): void {
        if(this.estaEncendido){
            this.volumenActual = volumen
            console.log("el volumen ahora es: ")
        }
    }
}