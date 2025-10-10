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
            lbVidas.Text = "Vidas: " + VIDAS.ToString();
            timer1.Enabled = true;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                player.Left -= 10;
            }

            if (e.KeyCode == Keys.Right)
            {
                player.Left += 10;
            }

            if (e.KeyCode == Keys.Up)
            {
                player.Top -= 10;
            }

            if (e.KeyCode == Keys.Down)
            {
                player.Top += 10;
            }

            if (player.Bounds.IntersectsWith(reward.Bounds))
            {
                totem.Visible = true;

                MessageBox.Show("Felicidas, Ganaste!");
                totem.Visible = false;
                timer1.Enabled = false;
                player.Location = new Point(80, 300);

            }

            colision();
        }

        public void colision()
        {
            var paredes = new[] { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 };

            foreach (var pared in paredes)
            {
                if (player.Bounds.IntersectsWith(pared.Bounds))
                {

                    player.Location = new Point(80, 300);

                    if (VIDAS > 0)
                    {
                        VIDAS--;
                        lbVidas.Text = "Vidas: " + VIDAS;
                    }

                    if (VIDAS == 0)
                    {
                        MessageBox.Show("¡Has perdido!");
                        GameOver.Visible = true;
                        this.Close();
                    }

                    return;
                }
            }
        }

        public void cronometro()
        {
            CONTADOR++;
            if(CONTADOR <= 9)
            {
                lbTiempo.Text = "0" + CONTADOR.ToString();
            }else
            {
                lbTiempo.Text = CONTADOR.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cronometro();
        }

        private void totem_Click(object sender, EventArgs e)
        {

        }
    }
}
