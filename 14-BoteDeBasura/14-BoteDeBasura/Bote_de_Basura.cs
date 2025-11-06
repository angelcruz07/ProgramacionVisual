using System.Windows.Forms;
using System.Drawing;

namespace Bote_de_Basura
{
    public class BoteDeBasura
    {
        public PictureBox ControlVisual { get; private set; }

        public BoteDeBasura(PictureBox pictureBox)
        {
            this.ControlVisual = pictureBox;
        }

        public Rectangle Limites()
        {
            return ControlVisual.Bounds;
        }
    }
}