using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {

        public string Latir()
        {
            return "Au! Au!";
        }

        public string QuandoDevoComer(int peso)
        {
            return "Como tenho " + peso + "kg, devo comer " + ((peso * 1000) * 5 / 100) + "g por dia";
        }
    }
}
