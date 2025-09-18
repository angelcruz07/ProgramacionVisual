using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VelocidadDeTransferenciaDeArchivos
{
    internal class Calculos
    {
        public double CalcularTiempoDeTransferencia(double fileSize, double velocidadTransmicion)
        {
            double eficienciaRed = 0.85;

            float tiempo = (float)((fileSize * 8) / (velocidadTransmicion * eficienciaRed));

            return tiempo;
        }
    }
}
