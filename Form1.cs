﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml.Linq;

namespace practica10fun2
{
    public partial class Form1 : Form
    {

        private Timer timer;
        private List <Form1> Locate = new List<Form1>();

        private Dictionary<string, ListaProductos> productos;

        public string cx { get; private set; }
        public string cy { get; private set; }
        public string cz { get; private set; }
        public string ra { get; private set; }
        public string ea { get; private set; }

        public Form1()
        {
            InitializeComponent();
            timer = new Timer
            {
                Interval = 1000 // 1000 ms = 1 segundo
            };
            timer.Tick += Timer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            
            productos = new Dictionary<string, ListaProductos>
    {
        { "Notch", new ListaProductos("Notch", 256m) },
        { "Golden Carrot", new ListaProductos("Golden Carrot", 3m) },
        { "Apple", new ListaProductos("Apple", 1m) },
        { "Golden Apple", new ListaProductos("Golden Apple", 10m) },
        { "Diamante", new ListaProductos("Diamante", 7m) },
        { "Hierro", new ListaProductos("Hierro", 1m) },
        { "Cactus", new ListaProductos("Cactus", 1m) },
        { "Arena", new ListaProductos("Arena", 4m) },
        { "Trigo", new ListaProductos("Trigo", 1m) },
        { "Grava", new ListaProductos("Grava", 4m) }
    };

            // Configura las columnas del DataGridView
            dataGridView.ColumnCount = 3;
            dataGridView.Columns[0].Name = "Item";
            dataGridView.Columns[1].Name = "Precio";
            dataGridView.Columns[2].Name = "Cantidad";
            // Inicialmente ocultar el DataGridView y el label
            labelTotal.Visible = false;
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
            Apartado1.Visible = false;
            dataGridView.Visible = false;
            menuStrip1.Visible = false;
            labelTotal.Visible = false;

            //mostrar

            Direccion.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            {
                // Cambiar la visibilidad del DataGridView
                dataGridView.Visible = !dataGridView.Visible;
                labelTotal.Visible = !labelTotal.Visible;
                PayDay.Visible = !PayDay.Visible;

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
                ActualizarTotal();
            }
        }
        
        private void EGA(object sender, EventArgs e)
        {
            AñadirOActualizarProducto("Notch");
            maea.Visible = true;

            timer.Start();
        }

        private void GCrrt(object sender, EventArgs e)
        {
            AñadirOActualizarProducto("Golden Carrot");
            zada.Visible = true;

            timer.Start();
        }

        private void Dmnd(object sender, EventArgs e)
        {
            AñadirOActualizarProducto("Diamante");
            de.Visible = true;

            timer.Start();
        }

        private void GnApp(object sender, EventArgs e)
        {
            AñadirOActualizarProducto("Golden Apple");
            mada.Visible = true;

            timer.Start();
        }

        private void Apple(object sender, EventArgs e)
        {
            AñadirOActualizarProducto("Apple");
            ma.Visible = true;

            timer.Start();
        }
       
        private void ActualizarTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                if (fila.Cells["Item"].Value != null)
                {
                    decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
                    int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    total += precio * cantidad;
                }
            }

            labelTotal.Text = $"Total: ${total:F2}";
            Pagar.Text = $"Total: ${total:F2}";
        }

        private void buttonActualizarTotal_Click(object sender, EventArgs e)
        {
            {
              
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void mostrar1_Click(object sender, EventArgs e)
        {
          

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void hierro(object sender, EventArgs e)
        {
            AñadirOActualizarProducto("Hierro");
            ho.Visible = true;

            timer.Start();
        }

        private void cactus(object sender, EventArgs e)
        {
            AñadirOActualizarProducto("Cactus");
            cs.Visible = true;

            timer.Start();
        }

        private void arena(object sender, EventArgs e)
        {
            AñadirOActualizarProducto("Arena");
            aa.Visible = true;

            timer.Start();
        }

        private void trigo(object sender, EventArgs e)
        {
            AñadirOActualizarProducto("Trigo");
            to.Visible = true;

            timer.Start();
        }

        private void grava(object sender, EventArgs e)
        {
            AñadirOActualizarProducto("Grava");
            ga.Visible = true;

            timer.Start();
        }

        private void Borrar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Elimina la fila seleccionada
                dataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Ocultar la imagen y detener el temporizador
            ma.Visible = false;
            mada.Visible = false;
            maea.Visible = false;
            zada.Visible = false;
            to.Visible = false;
            ga.Visible = false;
            aa.Visible = false;
            cs.Visible = false;
            de.Visible = false;
            ho.Visible = false;

            timer.Stop();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearCuentaNuevaToolStripMenuItem.Visible = false;
            iniciarSesionToolStripMenuItem.Visible = false;
            inicioDeSesion form1 = new inicioDeSesion();//si es correcto pasar al formilario
            form1.Show();
            this.Hide();
            
        }

        private void crearCuentaNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearCuentaNuevaToolStripMenuItem.Visible = false;
            iniciarSesionToolStripMenuItem.Visible = false;
            NuevaCuenta form1 = new NuevaCuenta();//si es correcto pasar al formilario
            form1.Show();
            this.Hide();
            
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearCuentaNuevaToolStripMenuItem.Visible = true;
            iniciarSesionToolStripMenuItem.Visible = true;
        }

        private void AR_Click(object sender, EventArgs e)
        {
            Datos.DataSource = null;
            cx = tx_CX.Text;
            cy = tx_CY.Text;
            cz = tx_CZ.Text;
            ra = tx_Ra.Text;
            ea = tx_EA.Text;

            Form1 L = new Form1();
            L.cx = cx; L.cy = cy; L.cz = cz; L.ra = ra; L.ea = ea;
            Locate.Add(L);
            tx_CX.Text = "";
            tx_CY.Text = "";
            tx_CZ.Text = "";
            tx_EA.Text = "";
            tx_Ra.Text = "";
            Datos.DataSource = Locate;


            Apartado1.Visible = true;
            menuStrip1.Visible = true;
            Direccion.Visible = false;
        }

        private void Cr_Click(object sender, EventArgs e)
        {

            Apartado1.Visible = true;
            menuStrip1.Visible = true;
            Direccion.Visible = false;
            
        }

        private void PayDay_Click(object sender, EventArgs e)
        {
            Pagofinal.Visible = true;

            Apartado1.Visible = false;
            dataGridView.Visible = false;
            menuStrip1.Visible = false;
            labelTotal.Visible = false;
            PayDay.Visible = false;
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("pago completado, su paquete sera entregado pronto." +
                "tu direccion sera enviada al repartidor" +
                "!!!en caso de no tener direccion el paquete no sera entregado¡¡¡" +
                "Gracias por comprar");

            Apartado1.Visible = true;
            menuStrip1.Visible = true;

            Pagofinal.Visible = false;
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioAdmin.Visible = true;
            Apartado1.Visible = false;
            dataGridView.Visible = false;
            menuStrip1.Visible = false;
            labelTotal.Visible = false;
            PayDay.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = "Derek";//ususario
            string password = "yy130808";//contraseña del usuario correspondiente
            string nombre2 = "Alex";//ususario
            string password2 = "1327";//contraseña del usuario correspondiente
            string nombre3 = "Axel";//ususario
            string password3 = "1234";//contraseña del usuario correspondiente
            string nombre4 = "Carlos";//ususario
            string password4 = "1234";//contraseña del usuario correspondiente
            if (!string.IsNullOrEmpty(tx_ausuario.Text) && !string.IsNullOrEmpty(tx_acontraseña.Text))//comprobar si hay algo en los textbox
            {
                if ((tx_ausuario.Text == nombre && tx_acontraseña.Text == password) ||//comprobar contraseñas de los ususarios
        (tx_ausuario.Text == nombre2 && tx_acontraseña.Text == password2) ||
        (tx_ausuario.Text == nombre3 && tx_acontraseña.Text == password3) ||
        (tx_ausuario.Text == nombre4 && tx_acontraseña.Text == password4))
                {
                    Datos.Visible = true;
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Inténtalo de nuevo.❌");//si no, mostrar cuadro de texto
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa usuario y contraseña😃.");//si no mostrar cuadro de texto
            }
        }

        private void mostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrarContraseña.Checked)//comprovar si esta o no marcado el cuiadro de lista
            {
                tx_acontraseña.PasswordChar = '\0'; // Mostrar texto
            }
            else
            {
                tx_acontraseña.PasswordChar = '*'; // Ocultar texto con *
            }
        }

        private void label34_Click(object sender, EventArgs e)
        {
            Datos.Visible = false;
            InicioAdmin.Visible = false;

            menuStrip1.Visible = true;
            Apartado1.Visible = true;
        }
    }
    
}
    


    

