using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Clases
{
    public partial class Controles : Form
    {
        public Controles()
        {
            InitializeComponent();
        }

        private void Controles_Load(object sender, EventArgs e)
        {
            // Cuando se carga el componente
            CboAntojitos.Items.Add("Pozole");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Add(txtDato.Text.ToString());
            lstAntojito.Items.Add(CboAntojitos.Text.ToString());
            txtDato.Clear();

            
            CboAntojitos.SelectedIndex = -1;
            txtDato.Focus();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            foreach (var item in lstAntojito.Items)

            {
                string dato = item.ToString();
                string pos = lstAntojito.Items.IndexOf(item).ToString();

                MessageBox.Show(dato + " Posición " + pos);
            }
        }

        private void lstAntojito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
