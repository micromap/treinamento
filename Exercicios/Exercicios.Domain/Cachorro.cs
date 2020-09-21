using System;
using System.Globalization;

namespace Exercicios.Domain
{
    public class Cachorro
    {

        public string Latir()
        {
            return "Au! Au!";
        }

      

        public string QuantoDevoComer(int peso, double percentual)
        {

            double quantoComer =1000 * (peso * percentual);
            return "Como tenho " + peso + "Kg, devo comer " + quantoComer + "g por dia";
        }

    }
}
