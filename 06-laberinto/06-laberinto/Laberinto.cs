using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_laberinto
{
    public partial class Laberinto : Form
    {
        int VIDAS = 3;
        int CONTADOR = 0;

        public Laberinto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                if(player1.Bounds.IntersectsWith(p1.Bounds)
                    || player1.Bounds.IntersectsWith(p2.Bounds)
                    || player1.Bounds.IntersectsWith(p6.Bounds)
                    || player1.Bounds.IntersectsWith(p3.Bounds)

                 )
                {
                    player1.Location = new Point(20, 140);
                    if(VIDAS > 0)
                    {
                        VIDAS--;
                        lbVidas.Text = "Vidas: " + VIDAS;
                    }

                    if(VIDAS == 0)
                    {
                        MessageBox.Show("Game Over");
                        GameOver.Visible = true;
                        this.Close();
                    }

                } else
                {
                    player1.Left -= 10;
                }        
            }

            if (e.KeyCode == Keys.Right)
            {
                player1.Left += 10;
            }

            if (e.KeyCode == Keys.Down)
            {
                player1.Top += 10;
            }

            if (e.KeyCode == Keys.Down)
            {
                player1.Left -= 10;
            }


        }

        public void cronometro()
        {
            CONTADOR++;
            if(CONTADOR <= 9)
            {
                lbTiempo.Text = "00:0" + CONTADOR;
            }else
            {
                lbTiempo.Text = "00:" + CONTADOR.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
