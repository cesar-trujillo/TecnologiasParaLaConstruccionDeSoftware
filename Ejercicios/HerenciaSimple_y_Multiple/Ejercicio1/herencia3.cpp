#include <iostream>

using namespace std;

class Animal {

    public:
        string nombre;

        Animal(string nombre) : nombre(nombre) {
            cout << "Animal constructor" << endl;
        }

        void  andar(){
            cout << nombre << " está andando" << endl;
        }
};

class Perro : public Animal {
    public:
        Perro(string nombre) : Animal(nombre) {}

        void ladrar(){
            cout << "nombre " << "está ladrando" << endl;
        }

        void andar(){
            cout << nombre << " esta corriendo " << endl;
        }
};



class Volador : virtual public Animal{
    public:
        Volador(string nombre) : Animal(nombre) {}

        void andar(){
            cout << nombre << " está volando" << endl;
        }
};

class Nadador : virtual public Animal{
    public: 
        Nadador(string nombre) : Animal(nombre) {}

        void andar(){
            cout << nombre << " está nadando" << endl;
        }
};

class Pato : public Volador, public Nadador{
    public: 
        Pato(string nombre) : Animal(nombre), Nadador(nombre), Volador(nombre) {}

        void graznar(){
            cout << nombre << " está graznando" << endl;
        }

        void andar(){
            cout << nombre << " está caminando" << endl;
        }
};

int main(){
    Perro perro1("pako");
    perro1.ladrar();
    perro1.andar();

    Pato pato1("justin");
    pato1.andar();

    Volador volador("vane");
    Nadador nadador("alexa");

    volador.andar();
    nadador.andar();

    return 0;
};