using System;
using System.ComponentModel;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string latir()
        {
            return "Au! Au!";
        }

        public double quantoDevoComer(int peso)
        {
            double result = ((peso * 1000) * 5 / 100);

            return result;
        }
    }
}
