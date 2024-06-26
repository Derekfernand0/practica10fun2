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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace practica10fun2
{
    public partial class NuevaCuenta : Form
    {
        private string userFile = "users.txt";
        public NuevaCuenta()
        {
            InitializeComponent();
        }
        private void RegisterUser()
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

            // Ruta del archivo donde se guardarán las cuentas
            string userFile = "users.txt";

            // Verificar si el archivo existe y si el usuario ya está registrado
            if (File.Exists(userFile))
            {
                using (StreamReader sr = new StreamReader(userFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == username)
                        {
                            MessageBox.Show("El nombre de usuario ya existe. Por favor, elige otro.");
                            return;
                        }
                    }
                }
            }

            // Guardar la nueva cuenta en el archivo
            using (StreamWriter sw = new StreamWriter(userFile, true))
            {
                sw.WriteLine($"{username},{password}");
            }

            MessageBox.Show("Cuenta registrada exitosamente.");
            // Limpiar los campos de texto después de registrar
            tx_contraseña.Clear();
            tx_usuario.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterUser();
            inicioDeSesion form1 = new inicioDeSesion();
            form1.Show();
            this.Hide();
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
