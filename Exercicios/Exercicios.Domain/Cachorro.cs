
using System;
using Microsoft.Win32.SafeHandles;

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
            string saida = "";
            int grama = peso * 1000;

            double porcento = grama * 0.05;

            Console.WriteLine(porcento);

            saida = "Como tenho "+ peso +"Kg,devo comer "+ porcento +"g por dia";

            /*if (peso == 1)
            { saida = "Como tenho 1Kg,devo comer 50g por dia";
            }*/

            /*if (peso == 30)
            {
                saida = "Como tenho 30Kg,devo comer 1500g por dia";
            }*/

            /*if (peso == 15)
            {
                saida = "Como tenho 15Kg,devo comer 750g por dia";
            }*/

            return saida;
        }

    }
}
