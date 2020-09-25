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

            //return string.Join("", nome, " pesando ", peso, "Kg deve comer ", (peso * 1000) * (0.05), "g diariamente.");
            //return $"{nome} pesando {peso}Kg deve comer {(peso * 1000) * (0.05)}g diariamente.";
            //return string.Format("{0}{1}{2}{3}{4}{5}", nome," pesando ", peso,"Kg deve comer ", (peso * 1000) * (0.05), "g diariamente.");
        }
    }
}
