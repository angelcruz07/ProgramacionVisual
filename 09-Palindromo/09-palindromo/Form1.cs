using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _09_palindromo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string text = txtPhrase.Text;
            text = text.ToLower();

            string textoNormalizado = Regex.Replace(text, "[^a-z0-9]", "");

            char[] charArray = textoNormalizado.ToCharArray();

            Array.Reverse(charArray);
            
            string reversedText = new string(charArray);

            char[] sortedArray = (char[])charArray.Clone();
            Array.Sort(sortedArray);
            string sortedText = new string(sortedArray);

            //lblSinEspacios.Text = $"Texto sin espacios: {textoNormalizado}";
            //lblAlrevez.Text = $"Texto al revés: {reversedText}";

            if (textoNormalizado == reversedText)
            {
                MessageBox.Show("Es un palíndromo");

                txtPhrase.Clear();
            }
            else
            {
                MessageBox.Show("No es un palíndromo");
                txtPhrase.Clear();
            }
        }

        private void lblSinEspacios_Click(object sender, EventArgs e)
        {

        }
    }
}
