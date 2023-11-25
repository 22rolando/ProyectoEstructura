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


    public partial class FrmArboles : Form
    {
        private ClaseNodo raizArbol;
        public FrmArboles()
        {
            InitializeComponent();
            raizArbol = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnInsertarNodo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxBIngresarnodo.Text, out int valor))
            {
                if (raizArbol == null)
                {
                    raizArbol = new ClaseNodo(valor);
                }
                else
                {
                    InsertarEnArbol(raizArbol, valor);
                }

                ActualizarTreeView(raizArbol);

                // Limpia el TextBox después de la inserción
                TxBIngresarnodo.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertarEnArbol(ClaseNodo nodo, int valor)
        {
            if (valor < nodo.Valor)
            {
                if (nodo.Izquierdo == null)
                {
                    nodo.Izquierdo = new ClaseNodo(valor);
                }
                else
                {
                    InsertarEnArbol(nodo.Izquierdo, valor);
                }
            }
            else if (valor > nodo.Valor)
            {
                if (nodo.Derecho == null)
                {
                    nodo.Derecho = new ClaseNodo(valor);
                }
                else
                {
                    InsertarEnArbol(nodo.Derecho, valor);
                }
            }
        }

        private void BtnBuscarElimNodo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxBEliminiraBuscarNodo.Text, out int valorBuscado))
            {
                bool encontrado = raizArbol != null && raizArbol.Buscar(valorBuscado);
                MessageBox.Show($"El nodo {valorBuscado} en el árbol: {encontrado}", "Resultado de la búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnImprimirNodo_Click(object sender, EventArgs e)
        {
            if (raizArbol != null)
            {
                string resultado = raizArbol.Imprimir();
                MessageBox.Show(resultado, "Árbol Binario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El árbol está vacío.", "Árbol Binario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarTreeView(ClaseNodo raiz)
        {
            treeView1.Nodes.Clear();
            AgregarNodosAlTreeView(treeView1.Nodes, raiz);
        }

        private void AgregarNodosAlTreeView(TreeNodeCollection nodos, ClaseNodo nodo)
        {
            if (nodo != null)
            {
                TreeNode nuevoNodo = nodos.Add(nodo.Valor.ToString());
                AgregarNodosAlTreeView(nuevoNodo.Nodes, nodo.Izquierdo);
                AgregarNodosAlTreeView(nuevoNodo.Nodes, nodo.Derecho);
            }
        }

        private void FrmArboles_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxBEliminar.Text, out int valorAEliminar))
            {
                raizArbol = raizArbol.Eliminar(valorAEliminar);
                ActualizarTreeView(raizArbol);

                TxBEliminar.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
