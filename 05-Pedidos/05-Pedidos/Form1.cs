using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Pedidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double subtotal = 0, iva = 0, total = 0;

            foreach (DataGridViewRow row in Tabla.Rows)
            {
                subtotal += Convert.ToDouble(row.Cells["ColSubtotal"].Value);
            }

            TxtSubtotal.Text = subtotal.ToString();

            iva = subtotal * 0.16;
            TxtIva.Text = iva.ToString();

            total = subtotal + iva;
            TxtTotal.Text = total.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreProduct = CboProducto.SelectedItem.ToString();
            int cantidad = 0;
            double subtotal = 0, precio = 0;

            cantidad = Convert.ToInt32(TxtCantidad.Text);
            precio = Convert.ToInt32(TxtPrecio.Text);
            subtotal = cantidad * precio;
            Tabla.Rows.Add(nombreProduct, TxtCantidad.Text, TxtPrecio.Text, subtotal.ToString());
            Clean();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Clean();
            Tabla.Rows.Clear();
        }

        public void Clean()
        {
            TxtPedido.Clear();
            CboCliente.SelectedIndex = -1;
            TxtDireccion.Clear();
            CboProducto.SelectedIndex = -1;
            TxtCantidad.Clear();
            TxtPrecio.Clear();
            TxtSubtotal.Clear();
            TxtIva.Clear();
            TxtTotal.Clear();
            TxtPedido.Clear();
            TxtPedido.Focus();
        }
    }
}
