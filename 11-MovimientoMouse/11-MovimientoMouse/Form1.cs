using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovimientoMouse
{
    public partial class Form1 : Form
    {
        int posMouseFormX, posMouseFormY;
        int posImageX, posImageY;

        bool botonPresionado = false;

        private void Image1_MouseDown(object sender, MouseEventArgs e)
        {
            posMouseFormX =  e.Location.X;
            posMouseFormY =  e.Location.Y;

            botonPresionado = true;

        }

        private void Image1_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormX = posImageX + e.Location.X;
            posMouseFormY = posImageY + e.Location.Y;

            if (botonPresionado)
            {
                MoverMouse();
            }
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Image1_MouseUp(object sender, MouseEventArgs e)
        {
            botonPresionado = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            posImageY = Image1.Location.Y;
            posImageX = Image1.Location.X;
        }

        public void MoverMouse()
        {
            Image1.Location = new System.Drawing.Point(
                posMouseFormX - posImageX,
                posMouseFormY - posImageY);
            posImageX = Image1.Location.X;
            posImageY = Image2.Location.Y;

            if(Image1.Bounds.IntersectsWith(Image2.Bounds))
            {
                MessageBox.Show("¡¡ Gane !!");
            }
        }
    }
}
