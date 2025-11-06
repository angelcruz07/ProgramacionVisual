using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bote_de_Basura;

namespace BoteBasura
{
    public partial class Form1 : Form
    {
        private Papel papel;
        private BoteDeBasura bote;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            papel = new Papel(picBasura);// Inicializa las instancias
            bote = new BoteDeBasura(picBote);// Inicializa las instancias
            papel.ControlVisual.MouseUp += VerificarResultadoFinal;// Suscribe el evento MouseUp para verificar el resultado

        }

        private void VerificarResultadoFinal(object sender, MouseEventArgs e)
        {
            if (papel.Colision(bote))// Si colisiona
            {
                // Éxito: Colisionó
                papel.Visible(false);// Oculta el papel
            }
            else
            {

                papel.RegresarAInicio(); // Vuelve a la posición original
            }
        }
    }
}
