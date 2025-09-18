using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  // Utilizar controles

namespace _03_Clases
{
    internal class Procesos
    {
        // Lista por referencia
        public void LlenarLista( ListBox listaLlena, ref ListBox listaVacia)
        {
            listaVacia.Items.Clear();

            // Llena la lista vacia con la lista llena
            foreach (var item in listaLlena.Items)
            {
                listaVacia.Items.Add(item.ToString());
            }
        }
    }
}
