using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_JuegoDeDatos
{
    internal class Player
    {
        public int Score { get; set; } = 0;

        public void AddPoints(int points)
        {
            this.Score += points;
        }

        // Método para reiniciar el puntaje a 0.
        public void ResetScore()
        {
            this.Score = 0;
        }   
    }
}
