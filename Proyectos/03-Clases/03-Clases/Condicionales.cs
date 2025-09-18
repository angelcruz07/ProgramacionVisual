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
    public partial class Condicionales : Form
    {

        // Global Variable
        int num = 0;
        Operaciones operaciones = new Operaciones();

        public Condicionales()
        {
            InitializeComponent();
        }

        private void Condicionales_Load(object sender, EventArgs e)
        {
            view1.Visible = false;
            view2.Visible = false;
            view3.Visible = false;
            view4.Visible = false;
            view5.Visible = false;
            view6.Visible = false;
        }

        public void lanzar()
        {
            num = operaciones.aleatrorio(1, 6);

            switch(num)
            {
                case 1:
                    view1.Visible = true;
                    view2.Visible = false;
                    view3.Visible = false;
                    view4.Visible = false;
                    view5.Visible = false;
                    view6.Visible = false;
                    break;
                case 2:
                    view1.Visible = false;
                    view2.Visible = true;
                    view3.Visible = false;
                    view4.Visible = false;
                    view5.Visible = false;
                    view6.Visible = false;
                    break; 
                case 3:
                view1.Visible = false;
                view2.Visible = false;
                view3.Visible = true;
                view4.Visible = false;
                view5.Visible = false;
                view6.Visible = false;
                    break;
                case 4:
                    view1.Visible = false;
                    view2.Visible = false;
                    view3.Visible = false;
                    view4.Visible = true;
                    view5.Visible = false;
                    view6.Visible = false;
                    break;
                case 5:
                    view1.Visible = false;
                    view2.Visible = false;
                    view3.Visible = false;
                    view4.Visible = false;
                    view5.Visible = true;
                    view6.Visible = false;
                    break;
                case 6:
                    view1.Visible = false;
                    view2.Visible = false;
                    view3.Visible = false;
                    view4.Visible = false;
                    view5.Visible = false;
                    view6.Visible = true;
                break;

            }

        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lanzar();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }
    }
}