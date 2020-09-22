using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Latir()
        {
            return "Au Au!";
        }

        public string QuantoDevoComer(int peso)
        {
            double total;
            total = (peso * 0.05) * 1000;

            return "Como tenho " + peso + "kg, tenho que comer " + total + "g";
        }
    }

}
