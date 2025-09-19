using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_JuegoDeDatos
{
    internal class Character
    {
        public int Score(int lastPoints, int newPoints )
        {
            return lastPoints += newPoints;
        }
    }
}
