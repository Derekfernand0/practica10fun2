using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica10fun2
{
    public partial class inicioDeSesion : Form
    {
        private List<Form1> Sia = new List<Form1>();
        public string ic;
        public string Iniciodesesion
        {
            get { return this.ic; }
            set { this.ic = value; }
        }
        public inicioDeSesion()
        {
            InitializeComponent();
        }
        private void LoginUser()
        {
            // Obtener los valores de los TextBoxes
            string username = tx_usuario.Text;
            string password = tx_contraseña.Text;

            // Validar que no estén vacíos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            // Ruta del archivo donde se guardan las cuentas
            string userFile = "users.txt";

            // Verificar si el archivo existe
            if (!File.Exists(userFile))
            {
                MessageBox.Show("No hay usuarios registrados.");
                return;
            }

            // Validar las credenciales
            bool loginSuccessful = false;
            using (StreamReader sr = new StreamReader(userFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    // Comparar usuario y contraseña
                    if (parts[0] == username && parts[1] == password)
                    {
                        loginSuccessful = true;
                        break;
                    }
                }
            }

            if (loginSuccessful)
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                //redirigir al usuario a la siguiente pantalla o formulario
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 SIA = new Form1();
            LoginUser();
            Ic.Text = "1";
            SIA.Iniciodesesion = Ic.Text;
        }

        private void mostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrarContraseña.Checked)//comprovar si esta o no marcado el cuiadro de lista
            {
                tx_contraseña.PasswordChar = '\0'; // Mostrar texto
            }
            else
            {
                tx_contraseña.PasswordChar = '*'; // Ocultar texto con *
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            NuevaCuenta form1 = new NuevaCuenta();//si es correcto pasar al formilario
            form1.Show();
            this.Hide();
        }

        private void inicioDeSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
