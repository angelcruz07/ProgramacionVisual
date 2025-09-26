using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_JuegoDeDatos
{
    public partial class Imagenes : Form
    {
        public Imagenes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Elige una imagen";
            openFileDialog1.InitialDirectory = "C:\\Users\\Angel\\OneDrive\\Documentos\\Programación Visual\\assets";
            openFileDialog1.FileName = txtUrl.Text;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtUrl.Text = openFileDialog1.FileName;
                foto.ImageLocation = openFileDialog1.FileName;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
