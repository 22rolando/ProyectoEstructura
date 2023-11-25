using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructura
{
    public partial class FrmGrafos : Form
    {
        ClaseGrafo grafo = new ClaseGrafo(0);
        public FrmGrafos()
        {
            InitializeComponent();
        }

        private void BtnInsertarGrafo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxBIngresarnodoG.Text, out int valor))
            {
                ClaseGrafo nuevoNodo = new ClaseGrafo(valor);
                grafo.InsertarNodo(nuevoNodo);

                // Limpia el TextBox después de la inserción
                TxBIngresarnodoG.Text = "";

                // Actualiza la visualización del grafo en el TreeView
                MostrarGrafoTree();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido para insertar en el grafo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarGrafoTree()
        {
            treeView1.Nodes.Clear();  // Limpiar nodos existentes

            if (grafo != null)
            {
                // Agregar el nodo raíz al TreeView
                TreeNode rootNode = CrearTreeNode(grafo, new HashSet<ClaseGrafo>());
                treeView1.Nodes.Add(rootNode);
            }
        }

        private TreeNode CrearTreeNode(ClaseGrafo nodo, HashSet<ClaseGrafo> visitedNodes)
        {
            if (visitedNodes.Contains(nodo))
            {
                return new TreeNode($"Valor: {nodo.Valor} (Ciclo)");
            }

            visitedNodes.Add(nodo);

            TreeNode treeNode = new TreeNode($"Valor: {nodo.Valor}");

            foreach (var vecino in nodo.Vecinos)
            {
                TreeNode childNode = CrearTreeNode(vecino, visitedNodes);
                treeNode.Nodes.Add(childNode);
            }

            visitedNodes.Remove(nodo);

            return treeNode;
        }

        private void BtnBuscarNodoG_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxBBuscarNodoG.Text, out int valorBuscado))
            {
                ClaseGrafo nodoEncontrado = BuscarNodo(grafo, valorBuscado);

                if (nodoEncontrado != null)
                {
                    MessageBox.Show($"Nodo con valor {valorBuscado} encontrado en el grafo.", "Búsqueda Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Nodo con valor {valorBuscado} no encontrado en el grafo.", "Búsqueda Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido para buscar en el grafo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxBBuscarNodoG.Text = "";
        }

        private ClaseGrafo BuscarNodo(ClaseGrafo nodo, int valorBuscado)
        {
            HashSet<ClaseGrafo> nodosVisitados = new HashSet<ClaseGrafo>();
            return BuscarNodoRecursivo(nodo, valorBuscado, nodosVisitados);
        }

        private ClaseGrafo BuscarNodoRecursivo(ClaseGrafo nodo, int valorBuscado, HashSet<ClaseGrafo> nodosVisitados)
        {
            if (nodo == null || nodosVisitados.Contains(nodo))
            {
                return null;
            }

            nodosVisitados.Add(nodo);

            if (nodo.Valor == valorBuscado)
            {
                return nodo;
            }

            foreach (var vecino in nodo.Vecinos)
            {
                ClaseGrafo resultadoBusqueda = BuscarNodoRecursivo(vecino, valorBuscado, nodosVisitados);
                if (resultadoBusqueda != null)
                {
                    return resultadoBusqueda;
                }
            }

            return null;
        }

        private void BtnEliminarNodoG_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxBEliminar.Text, out int valorEliminar))
            {
                if (grafo != null)
                {
                    ClaseGrafo nodoEliminar = BuscarNodo(grafo, valorEliminar);

                    if (nodoEliminar != null)
                    {
                        // Eliminar el nodo encontrado
                        EliminarNodo(grafo, nodoEliminar);

                        MessageBox.Show($"Nodo con valor {valorEliminar} eliminado del grafo.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar la visualización del grafo en el TreeView
                        MostrarGrafoTree();
                    }
                    else
                    {
                        MessageBox.Show($"Nodo con valor {valorEliminar} no encontrado en el grafo.", "Eliminación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido para eliminar en el grafo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarNodo(ClaseGrafo nodoPadre, ClaseGrafo nodoEliminar)
        {
            // Eliminar el nodo de los vecinos del nodo padre
            nodoPadre.Vecinos.Remove(nodoEliminar);

            // Eliminar recursivamente de los vecinos de los nodos restantes
            foreach (var vecino in nodoPadre.Vecinos)
            {
                EliminarNodo(vecino, nodoEliminar);
            }
        }

        private void BtnImprimirGrafo_Click(object sender, EventArgs e)
        {
            if (grafo != null)
            {
                string mensaje = ImprimirGrafo(grafo);
                MessageBox.Show(mensaje, "Grafo Impreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El grafo está vacío.", "Grafo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private string ImprimirGrafo(ClaseGrafo nodo)
        {
            StringBuilder sb = new StringBuilder();
            Stack<ClaseGrafo> nodos = new Stack<ClaseGrafo>();
            HashSet<ClaseGrafo> visitados = new HashSet<ClaseGrafo>();

            nodos.Push(nodo);

            while (nodos.Count > 0)
            {
                ClaseGrafo current = nodos.Pop();

                if (!visitados.Contains(current))
                {
                    sb.AppendLine($"Valor: {current.Valor}");

                    visitados.Add(current);

                    foreach (var vecino in current.Vecinos)
                    {
                        if (!visitados.Contains(vecino))
                        {
                            nodos.Push(vecino);
                        }
                    }
                }
            }

            return sb.ToString();
        }
    }
}
