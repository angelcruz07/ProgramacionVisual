using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadenas
{
    public partial class RFC : Form
    {
        public RFC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rfc = null;

            rfc = txtCurp.Text.Substring(0, 10);

            txtRfc.Text = "RFC: " + rfc.ToUpper();
        }
    }
}
