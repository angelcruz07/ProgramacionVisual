using System;
using System.Windows.Forms;

namespace _13_PuntoDeVenta
{
    public partial class Form1 : Form
    {
        double precioInfantil = 85;
        double precioDuo = 90;
        double precioFamiliar = 105;
        double precioTrio = 95;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            double subtotal = 0.0;
            double total = 0.0;

            int cantidad = 0;

           
            if (CboInfantil.Checked && int.TryParse(QuantityInfantil.Text, out cantidad))
            {
                subtotal += cantidad * precioInfantil;
            }

            if (CboDuo.Checked && int.TryParse(QuantityDuo.Text, out cantidad))
            {
                subtotal += cantidad * precioDuo;
            }

            if (CboFamiliar.Checked && int.TryParse(QuantityFamiliar.Text, out cantidad))
            {
                subtotal += cantidad * precioFamiliar;
            }

            if (CboTrio.Checked && int.TryParse(QuantityTrio.Text, out cantidad))
            {
                subtotal += cantidad * precioTrio;
            }

            double iva = subtotal * .16;
            total = subtotal + iva;
             
            TxtSubtotal.Text = subtotal.ToString();
            TxtIva.Text = iva.ToString();
            TxtPagar.Text = total.ToString();
        }

        private void BtnNueva_Click(object sender, EventArgs e)
        {
            CboInfantil.Checked = false;
            CboDuo.Checked = false;
            CboFamiliar.Checked = false;
            CboTrio.Checked = false;

            QuantityInfantil.Text = "";
            QuantityDuo.Text = "";
            QuantityFamiliar.Text = "";
            QuantityTrio.Text = "";

            TxtIva.Text = "";
            TxtPagar.Text = "";
            TxtSubtotal.Text = "";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CboInfantil_CheckedChanged(object sender, EventArgs e)
        {
            QuantityInfantil.Enabled = CboInfantil.Checked;
        }

        private void CboDuo_CheckedChanged(object sender, EventArgs e)
        {
            QuantityDuo.Enabled = CboDuo.Checked;
        }

        private void CboFamiliar_CheckedChanged(object sender, EventArgs e)
        {
            QuantityFamiliar.Enabled = CboFamiliar.Checked;
        }

        private void CboTrio_CheckedChanged(object sender, EventArgs e)
        {
            QuantityTrio.Enabled = CboTrio.Checked;
        }
    }
}
