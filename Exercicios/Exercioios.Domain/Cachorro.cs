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
            double qtdeRacao = peso * 0.10;
            string mensagem = "Como tenho " + peso +
                              "Kg, devo comer " + qtdeRacao +
                              "kg por dia";
            return mensagem;
        }

        public string QuantoIreiPesar(int peso)
        {
            double pesoFuturo =peso - (peso * 0.10);
            string mensagem = "Como tenho " + peso +
                              "Kg atualmente, daqui 10 anos irei pesar " + pesoFuturo + "kg";

            return mensagem;
        }

        public string QualMinhaIdade(int idade)
        {
            int idadeFutura = idade + 5;
            string mensagem = "Como tenho " + idade + " anos de idade, daqui 5 anos vou ter " + idadeFutura + " anos";

            return mensagem;
        }
    }
}

