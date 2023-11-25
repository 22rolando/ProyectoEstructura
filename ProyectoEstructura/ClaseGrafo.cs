using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructura
{
    internal class ClaseGrafo
    {

        public static ClaseGrafo instancia;

        public int Valor { get; }
        public List<ClaseGrafo> Vecinos { get; }

        public ClaseGrafo(int valor)
        {
            Valor = valor;
            Vecinos = new List<ClaseGrafo>();
        }

        public static ClaseGrafo ObtenerInstancia(int valor)
        {
            if (instancia == null)
            {
                instancia = new ClaseGrafo(valor);
            }

            return instancia;
        }
        public void InsertarNodo(ClaseGrafo nodo)
        {
            Vecinos.Add(nodo);
            nodo.Vecinos.Add(this);  // Asume que es un grafo no dirigido, si es dirigido, omite esta línea
        }
        public void Imprimir()
        {
            Console.WriteLine($"Nodo: {Valor}, Vecinos: {string.Join(", ", Vecinos.Select(vecino => vecino.Valor))}");
        }

        public ClaseGrafo Buscar(int valor)
        {
            if (Valor == valor)
                return this;

            foreach (var vecino in Vecinos)
            {
                var resultadoBusqueda = vecino.Buscar(valor);
                if (resultadoBusqueda != null)
                    return resultadoBusqueda;
            }

            return null;
        }

        public void Insertar(ClaseGrafo nodo)
        {
            Vecinos.Add(nodo);
        }

        public void Eliminar(int valor)
        {
            for (int i = 0; i < Vecinos.Count; i++)
            {
                if (Vecinos[i].Valor == valor)
                {
                    Vecinos.RemoveAt(i);
                    return;
                }
            }
        }


    }
}
