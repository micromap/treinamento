using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Latir()
        {
            return "Au! Au!";
        }

        public string QuantoDevoComer(int peso)
        {
            double racao;

            racao = ((peso * 1000) * 5) / 100;

            return "Como tenho " + peso + "kg, devo comer " + racao + "g por dia";
        }
    }
}
