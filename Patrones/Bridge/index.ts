import { ControlRemoto } from "./ControlRemoto";
import { ControlRemotoAvanzado } from "./ControlRemotoAvanzado";
import { Radio } from "./Radio";
import { TV } from "./TV";

const television = new TV();
const radio = new Radio();

const controlTv = new ControlRemoto(television);
const controlRadio = new ControlRemoto(radio);

const controlTvpro = new ControlRemotoAvanzado(television);
const controlRadioPro = new ControlRemotoAvanzado(radio);

controlTv.apagar();
controlTv.encender();
controlTv.cambiarVolumen(90);

controlRadioPro.encender();
controlRadioPro.cambiarVolumen(80)
controlRadioPro.mute()