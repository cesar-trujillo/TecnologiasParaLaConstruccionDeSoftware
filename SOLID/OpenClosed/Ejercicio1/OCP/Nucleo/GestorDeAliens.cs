using Ejercicio1.OCP.Aliens;
using Ejercicio1.OCP.Extensiones;
using Ejercicio1.OCP.Fabrica;
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

        public void RegistrarADN(MuestraADN muestra)
        {
            var nombre = muestra.Nombre;
            _escanearADN.Add((nombre, () => FabricaAlien.CrearDesdeMuestra(muestra)));
        }

        public bool TieneSupremo(IAliens alien) => _supremos.ContainsKey(alien.GetType());
        public IAliens CrearSupremo(IAliens alien) => _supremos[alien.GetType()]();
        public List<(string Nombre, Func<IAliens> Crear)> ObtenerFusion() => _fusiones;
        public IAliens ElegirAlienAleatorio()
        {
            var disponibles = ObtenerDesbloqueados();
            var indice = Random.Shared.Next(disponibles.Count);
            return disponibles[indice].Crear();
        }
    }
}
