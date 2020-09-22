using System;

namespace Exercicios.domain
{
    public class Cachorro
    {
        public string Latir()
        {
            return "AU! AU!";
        }

        public string QuantoDevoComer(int peso)
        {
            return $"Como tenho {peso}kg, devo comer {(peso*1000) * 0.05}g por dia";
        }
    }
}
