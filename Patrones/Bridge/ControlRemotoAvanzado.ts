import { ControlRemoto } from "./ControlRemoto";

export class ControlRemotoAvanzado extends ControlRemoto{
    
    mute() : void{
        this.dispositivo.cambiarVolumen(0)
        console.log("la tv esa muteada");
    }
}