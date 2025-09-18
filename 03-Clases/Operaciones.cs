using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Clases
{
    internal class Operaciones
    {
        public int aleatrorio(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
