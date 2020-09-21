using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public int peso;

        public string Latir()
        {
            return "AU! AU!";
        }

        public string QuantoDevoComer(int peso)
        {
            // 1KG = 1000g
            int pesoGrama = peso * 1000;
            double porcentagem = 5.0 / 100;
            double quantidade = pesoGrama * porcentagem;

            return "Como eu peso " + peso + "KG, devo comer " + quantidade + "g de ração.";
        }
    }
}
