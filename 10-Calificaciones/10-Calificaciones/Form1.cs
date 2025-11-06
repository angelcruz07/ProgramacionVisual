using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Calificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            int cantidadAlumnos = Convert.ToInt32(txtCantidadAlumnos.Text);
            
            for(int i = 0; i < cantidadAlumnos; i++)
            {
                TablaAlumnos.Rows.Add();
            }

            txtCantidadAlumnos.Clear();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedioGeneral = 0;
            double sumaPromedios = 0;
            int totalAlumnos = 0;

            // Limpiar cada que se calcula un nuevo promedio
            listPromedio.Items.Clear();


            foreach (DataGridViewRow row in TablaAlumnos.Rows )
            {
                // Verifica si la fila es nueva
                if (row.IsNewRow)
                {
                    continue; // Salta esta iteración y pasa a la siguiente fila
                }

                string name = Convert.ToString(row.Cells["ColName"].Value);
                double p1 = Convert.ToDouble(row.Cells["ColPrimerParcial"].Value);
                double p2 = Convert.ToDouble(row.Cells["ColSegundoParcial"].Value);
                double p3 = Convert.ToDouble(row.Cells["ColTercerParcial"].Value);

                double promedio = (p1 + p2 + p3) / 3;

                totalAlumnos += 1;
                sumaPromedios += promedio;

                listPromedio.Items.Add($"{name}: {promedio:F1}");
            }

            if (totalAlumnos > 0)
                promedioGeneral = sumaPromedios / totalAlumnos;
            else
                promedioGeneral = 0;

            lblGeneral.Text = $"Promedio general del grupo: {promedioGeneral:F1}";
        }
    }
}
