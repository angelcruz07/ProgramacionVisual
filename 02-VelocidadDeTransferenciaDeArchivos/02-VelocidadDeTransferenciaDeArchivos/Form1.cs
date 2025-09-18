using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_VelocidadDeTransferenciaDeArchivos
{
    public partial class Form1 : Form
    {
        Calculos calculos = new Calculos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double fileSizeValue = double.Parse(fileSize.Text);
            double velocidadTransmicionValue = double.Parse(velocidad.Text);

            double tiempo = calculos.CalcularTiempoDeTransferencia(fileSizeValue, velocidadTransmicionValue);
            
            txtVelocidadCalculada.Text = tiempo.ToString("0.00") + " segundos";
            fileSize.Clear();
            velocidad.Clear();
        }
    }
}
