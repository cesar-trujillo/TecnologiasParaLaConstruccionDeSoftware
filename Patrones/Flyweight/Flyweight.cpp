#include <iostream>
#include <map>
#include <string>
#include <vector>

using namespace std;

class TipoArbol{
    public: 
        string nombre;
        string color;
        string textura;

        TipoArbol(string nombre, string color, string textura){
            this->nombre = nombre;
            this->color = color;
            this->textura = textura;
        }

        void dibujar(int x, int y){
            cout << nombre << " de color" << color << " posicionado en (" << x << "," << y << ")\n";
        }
};

class Arbol{
    public:
    int x; 
    int y; 
    TipoArbol* tipo;

    Arbol(int x, int y, TipoArbol* tipo){
        this->x = x;
        this->y = y;
        this->tipo = tipo;
    }
    void dibujar(int x, int y){
        tipo->dibujar(x, y);
    }
};

class TipoArbolFactory{
    private: 
        static map<string, TipoArbol*> tipo;
    public:
        static TipoArbol* obtener(string nombre, string color, string textura){
            string clave = nombre + "|" + color + "|" + textura;
            if(tipo.find(clave) == tipo.end()){
                tipo[clave] = new TipoArbol(nombre, color, textura);
            }
            return tipo[clave];
        }
        static int total(){
            return tipo.size();
        }
        static void liberar(){
            for(auto p : tipo){
                delete p.second;
            }
            tipo.clear();
        }

};
map<string, TipoArbol*> TipoArbolFactory::tipo;

class Bosque{
    private: 
        vector<Arbol> arboles;
    public: 
        void plantar(int x, int y, string nombre, string color, string textura){
            TipoArbol* tipo = TipoArbolFactory::obtener(nombre, color, textura);
            arboles.push_back(Arbol(x,y,tipo));
        }

        void dibujar(){
            for(unsigned i = 0; i < arboles.size(); i ++){
                arboles[i].dibujar();
            }
        }
        int total(){

        }
};

int main(){
    Bosque bosque;
    for(int i = 0; i < 10000; i++){
        bosque.plantar(i+10, i+ 20, "pino", "verde", "pino.png");
    }

    bosque.dibujar();

    cout << "arboles dibujados" << bosque.total() << endl;
    cout << "arboles en memoria" << TipoArbolFactory::total() << endl;

    return 0;
}