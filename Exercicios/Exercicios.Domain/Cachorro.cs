using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {

        //Metodo criado pelo VS a partir do auto sugestao.
        public string Latir()
        {
            return "Au! Au!";
        }

        public double QuantoDevoComer(int peso, double porcIdeal)
        {
            return peso * (1+(porcIdeal/100));
        }
        
    }
}
