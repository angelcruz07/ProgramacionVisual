using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejemplo
{
    public partial class Form1 : Form
    {

        // Instanciar una clase
        Procesos procesos = new Procesos();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            int edad, fn;

            // Get the year of birth from the TextBox
            fn = Int32.Parse(txtNac.Text);
            
            edad = procesos.CalcularEdad(fn);

            MessageBox.Show("Hola " + txtName.Text + " tu edad es: " + edad + " años");

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String nombre;
            nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su nombre", "Registro de usuario");

            txtName.Text = nombre;
        }
    }
}
