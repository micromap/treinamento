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
    }
}

