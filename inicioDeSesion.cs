using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica10fun2
{
    public partial class inicioDeSesion : Form
    {
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
            LoginUser();
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
    }
}
