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
    public partial class NuevaCuenta : Form
    {
        public NuevaCuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBoxes
            string username = tx_nusuario.Text;
            string password = tx_ncontraseña.Text;

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
            tx_nusuario.Clear();
            tx_ncontraseña.Clear();
            inicioDeSesion form1 = new inicioDeSesion();//si es correcto pasar al formilario
            form1.Show();
            this.Hide();
        }
        }
    }
