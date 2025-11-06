using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadenas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string cadena = null;
            // Obtener la longitus 
            cadena = txtCadena.Text;

            txtLongitud.Text = Convert.ToString(cadena.Length);
            txtLongitud.Text = cadena.Length.ToString();

            txtUltimo.Text = cadena.Substring(cadena.Length - 1);
            txtPrimero.Text = cadena.Substring(0, 1);

            txtVarios.Text = cadena.Substring(1, 5);

            txtPosicion.Text = cadena.IndexOf("A").ToString();

            txtMayusculas.Text = cadena.ToUpper();
            txtMinusculas.Text = cadena.ToLower();

            txtBlancos.Text = cadena.Trim();
        }
    }
}
