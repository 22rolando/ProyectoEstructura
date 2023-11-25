using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructura
{
    internal class ClaseNodo
    {
        public int Valor { get; set; }
        public ClaseNodo Izquierdo { get; set; }
        public ClaseNodo Derecho { get; set; }

        public ClaseNodo(int valor)
        {
            Valor = valor;
            Izquierdo = null;
            Derecho = null;
        }

        // Método para insertar un nuevo nodo en el árbol
        public void Insertar(int nuevoValor)
        {
            if (nuevoValor < Valor)
            {
                if (Izquierdo == null)
                {
                    Izquierdo = new ClaseNodo(nuevoValor);
                }
                else
                {
                    Izquierdo.Insertar(nuevoValor);
                }
            }
            else
            {
                if (Derecho == null)
                {
                    Derecho = new ClaseNodo(nuevoValor);
                }
                else
                {
                    Derecho.Insertar(nuevoValor);
                }
            }
        }

        // Método para buscar un valor en el árbol
        public bool Buscar(int valorBuscado)
        {
            if (Valor == valorBuscado)
            {
                return true;
            }
            else if (valorBuscado < Valor && Izquierdo != null)
            {
                return Izquierdo.Buscar(valorBuscado);
            }
            else if (valorBuscado > Valor && Derecho != null)
            {
                return Derecho.Buscar(valorBuscado);
            }

            return false;
        }

        // Método para imprimir el árbol (in-order traversal)
        public string Imprimir()
        {
            StringBuilder resultado = new StringBuilder();
            ImprimirRec(this, resultado);
            return resultado.ToString();
        }

        private void ImprimirRec(ClaseNodo nodo, StringBuilder resultado)
        {
            if (nodo != null)
            {
                ImprimirRec(nodo.Izquierdo, resultado);
                resultado.Append($"{nodo.Valor} ");
                ImprimirRec(nodo.Derecho, resultado);
            }
        }

        // Método para eliminar un nodo en el árbol (a implementar según tus necesidades)
        public ClaseNodo Eliminar(int valorAEliminar)
        {
            return EliminarRec(this, valorAEliminar);
        }

        private ClaseNodo EliminarRec(ClaseNodo raiz, int valorAEliminar)
        {
            if (raiz == null)
            {
                return null;
            }

            // Buscar el nodo a eliminar en el subárbol izquierdo
            if (valorAEliminar < raiz.Valor)
            {
                raiz.Izquierdo = EliminarRec(raiz.Izquierdo, valorAEliminar);
            }
            // Buscar el nodo a eliminar en el subárbol derecho
            else if (valorAEliminar > raiz.Valor)
            {
                raiz.Derecho = EliminarRec(raiz.Derecho, valorAEliminar);
            }
            else
            {
                // Nodo encontrado, realizar la eliminación

                // Caso 1: Nodo hoja o con un solo hijo
                if (raiz.Izquierdo == null)
                {
                    return raiz.Derecho;
                }
                else if (raiz.Derecho == null)
                {
                    return raiz.Izquierdo;
                }

                // Caso 2: Nodo con dos hijos
                // Encontrar el sucesor inorden (nodo más pequeño en el subárbol derecho)
                raiz.Valor = MinValor(raiz.Derecho);

                // Eliminar el sucesor inorden
                raiz.Derecho = EliminarRec(raiz.Derecho, raiz.Valor);
            }

            return raiz;
        }

        private int MinValor(ClaseNodo nodo)
        {
            int minValor = nodo.Valor;
            while (nodo.Izquierdo != null)
            {
                minValor = nodo.Izquierdo.Valor;
                nodo = nodo.Izquierdo;
            }
            return minValor;
        }
       

    }
}
    

