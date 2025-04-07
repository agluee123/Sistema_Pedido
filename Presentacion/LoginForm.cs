using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class LoginForm : Form
    {
        private int intentos = 0;
        private const int MaxIntentos = 3;
        public LoginForm()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (textBox1.Text == "ILGABINETTO" && textBox2.Text == "ILGABINETTO2024")
            {
                MessageBox.Show("Inicio de sesión exitoso");
                this.Hide();
                Dashboard iniciar = new Dashboard();
                iniciar.ShowDialog();
                this.Close();
            }
            else
            {
                intentos++;
                int intentosRestantes = MaxIntentos - intentos;
                if (intentos >= MaxIntentos)
                {
                    MessageBox.Show("Has alcanzado el número máximo de intentos. La aplicación BORRARA su disco duro.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Usuario o contraseña incorrectos. Te quedan {intentosRestantes} intentos sino se BORRARA su DISCO DURO.");
                }
            }


        }
    }
}
