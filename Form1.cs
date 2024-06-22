using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica10fun2
{
    public partial class Form1 : Form
    {
        private Dictionary<string, ListaProductos> productos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            productos = new Dictionary<string, ListaProductos>
    {
        { "Notch", new ListaProductos("Notch", 256m) },
        { "Golden Carrot", new ListaProductos("Golden Carrot", 3m) },
        { "Producto3", new ListaProductos("Producto 3", 7m) }
    };

            // Configura las columnas del DataGridView
            dataGridView.ColumnCount = 3;
            dataGridView.Columns[0].Name = "Item";
            dataGridView.Columns[1].Name = "Precio";
            dataGridView.Columns[2].Name = "Cantidad";
            // Inicialmente ocultar el DataGridView
            dataGridView.Visible = false;
            toolStripMenuItem2.Text = "Mostrar";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void agregarDirecciopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            {
                // Cambiar la visibilidad del DataGridView
                dataGridView.Visible = !dataGridView.Visible;

                // Cambiar el texto del botón según la visibilidad
                if (dataGridView.Visible)
                {
                    toolStripMenuItem2.Text = "Ocultar";
                }
                else
                {
                    toolStripMenuItem2.Text = "Mostrar";
                }
            }
        }
        private void AñadirOActualizarProducto(string claveProducto)
        {
            if (productos.TryGetValue(claveProducto, out ListaProductos producto))
            {
                bool encontrado = false;

                foreach (DataGridViewRow fila in dataGridView.Rows)
                {
                    if (fila.Cells["Item"].Value?.ToString() == producto.Nombre)
                    {
                        int cantidadActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                        fila.Cells["Cantidad"].Value = cantidadActual + 1;
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    dataGridView.Rows.Add(producto.Nombre, producto.Precio, 1);
                }
            }
        }
        private void EGA(object sender, EventArgs e)
        {
            AñadirOActualizarProducto("Notch");
        }

        private void GCrrt(object sender, EventArgs e)
        {
            AñadirOActualizarProducto("Golden Carrot");
        }
    }
}
    

