using System;

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
            double racao = (peso * 1000) * 0.05;

            return "Como tenho " + peso + "kg, devo comer " + racao + "g por dia";
            
        }
    }
}
