using Ejercicio1.OCP.Aliens;
using Ejercicio1.OCP.Extensiones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1.OCP.Nucleo
{
    public class GestorDeAliens
    {
        private List<(string Nombre, Func<IAliens> Crear, bool Desbloqueado)> _catalogo = new()
        {
            ("Fuego", () => new Fuego(), true),
            ("Humungosaurio", ()=> new Humungosaurio(), true),
            ("Cuatro Brazos", () => new CuatroBrazos(), true)
        };

        private readonly List<(string Nombre, Func<IAliens> Crear)> _escanearADN = new();
        private readonly Dictionary<Type, Func<IAliens>> _supremos = new()
        {
            {typeof(Humungosaurio), () => new HumungosaurioSupremo()}
        };

        private readonly List<(string Nombre, Func<IAliens>)> _fusiones = new()
        {
            ("Humungosaurio + CuatroBrazos", () => new Fusion<Humungosaurio, CuatroBrazos>()),
            ("Fuego + Cuatro Brazos", () => new Fusion<Fuego,CuatroBrazos> ()),
            ("Fuego + Humungosaurio", () => new Fusion<Fuego,Humungosaurio> ()),

        };

        public List<(string Nombre, Func<IAliens> Crear)> ObtenerDesbloqueados()
        {
            var lista = _catalogo
                .Where(a => a.Desbloqueado)
                .Select(a => (a.Nombre, a.Crear))
                .ToList();
            lista.AddRange(_escanearADN);
            return lista;
        }

        public List<string> ObtenerDesbloqueados() => _catalogo.Where(a => a.Desbloqueado).Select( a => a.Nombre).ToList();

        public bool TieneSupremo(IAliens alien) => _supremos.ContainsKey(alien, GetType());
        {

        }
    }
}
