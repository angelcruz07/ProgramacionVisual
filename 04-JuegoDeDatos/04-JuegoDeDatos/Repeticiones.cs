using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _04_JuegoDeDatos
{
    public partial class Repeticiones : Form
    {
        // Variables globales
        Operaciones operaciones = new Operaciones();
        int r = 0, g = 0, b = 0;

        public Repeticiones()
        {
            InitializeComponent();
        }

        private void btnRepetir_Click(object sender, EventArgs e)
        {
            string estructura = cboEstructura.Items[cboEstructura.SelectedIndex].ToString();
            int tabla = Convert.ToInt32(txtTabla.Text);
            lstTablas.Items.Clear();

            switch (estructura)
            {
                case "while":
                    RWhile(tabla);
                    txtTabla.Clear();
                    cboEstructura.SelectedIndex = -1;
                    break;
                case "do while":
                    RDoWhile(tabla);
                    txtTabla.Clear();
                    cboEstructura.SelectedIndex = -1;
                    break;
                case "for":
                    RFor(tabla);
                    txtTabla.Clear();
                    cboEstructura.SelectedIndex = -1;
                    break;
            }
        }

        private void RWhile(int tabla)
        {
            int contador = 1;
            while (contador <= 10) {
                lstTablas.Items.Add(tabla + " x " + contador + " = " + (tabla * contador));
                contador++;
            }
        }

        private void RDoWhile(int tabla)
        {
           int contador = 1;
           do {
                lstTablas.Items.Add(tabla + " x " + contador + " = " + (tabla * contador));
                contador++;
           } while (contador <= 10);
        }

        private void RFor(int tabla)
        {
            for (int contador = 1; contador <= 10; contador++) {
                lstTablas.Items.Add(tabla + " x " + contador + " = " + (tabla * contador));
            }
        }
    }
}
