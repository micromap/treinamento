using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Latir()
        {
            return "Au! Au!";
        }

        public string QuantoDevoComer(int peso, string nome)
        {
            return nome + " pesando " + peso + "Kg deve comer " + (peso * 1000) * (0.05) + "g diariamente.";
        }
    }
}
