using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_JuegoDeDatos
{
    internal class Play
    {
        public int ThrowDiceRandon(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }

    }
}
