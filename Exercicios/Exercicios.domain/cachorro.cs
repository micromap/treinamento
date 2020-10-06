using System;

namespace Exercicios.domain
{
   public class Cachorro
    { 
        public string Latir()
        {
            return "Au Au!";         
        }

        public string QuantoDevoComer(int peso)
        {
            double quantidade = peso * 1000 * 0.05;
            return "Devo Comer : " + quantidade;
        }
    }
}
