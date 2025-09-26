using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_JuegoDeDatos
{
    internal class Game
    {
        Random r = new Random();
        public int ThrowDiceRandon(int min, int max)
        {
            return r.Next(min, max);
        }
    }
}
