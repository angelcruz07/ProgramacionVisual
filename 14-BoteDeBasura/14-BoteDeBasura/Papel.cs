using System.Windows.Forms;
using System.Drawing;

namespace Bote_de_Basura
{
    public class Papel
    {
        // PROPIEDADES (Datos esenciales)
        public PictureBox ControlVisual { get; private set; }
        public Point PosicionInicial { get; private set; } // Guarda la posición original

        // CAMPOS PRIVADOS (Estado de arrastre)
        private bool _estaArrastrando = false;
        private Point _posicionInicialMouse;

        // Constructor: Inicializa y suscribe eventos
        public Papel(PictureBox pictureBox)
        {
            this.ControlVisual = pictureBox;
            this.PosicionInicial = pictureBox.Location;

            // Suscribe los eventos del PictureBox a los métodos internos
            ControlVisual.MouseDown += ManejarMouseDown;
            ControlVisual.MouseMove += ManejarMouseMove;
            ControlVisual.MouseUp += ManejarMouseUp;
        }

        // MÉTODOS DE ARRASTRE
        private void ManejarMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _estaArrastrando = true;
                _posicionInicialMouse = e.Location;
            }
        }

        private void ManejarMouseMove(object sender, MouseEventArgs e)
        {
            if (_estaArrastrando)
            {
                int nuevoX = ControlVisual.Left + (e.X - _posicionInicialMouse.X);
                int nuevoY = ControlVisual.Top + (e.Y - _posicionInicialMouse.Y);

                ControlVisual.Location = new Point(nuevoX, nuevoY);
            }
        }

        private void ManejarMouseUp(object sender, MouseEventArgs e)
        {
            _estaArrastrando = false;
        }

        // MÉTODOS DE ACCIÓN Y COLISIÓN
        public Rectangle ObtenerLimites()
        {
            return ControlVisual.Bounds;
        }

        public void Visible(bool visible)
        {
            ControlVisual.Visible = visible;
        }

        public void RegresarAInicio()
        {
            ControlVisual.Location = PosicionInicial;
        }

        // Verifica si colisiona con el bote
        public bool Colision(BoteDeBasura objetivo)
        {
            return this.ObtenerLimites().IntersectsWith(objetivo.Limites());
        }
    }
}