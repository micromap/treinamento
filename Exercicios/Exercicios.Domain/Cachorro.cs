using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Latir()
        {
            return "Au! Au!";
        }

        public string QuantoDevoComer(double peso)
        {
            return $"Como tenho {peso}kg, devo comer {peso*0.05}kg por dia";
        }
    }
}