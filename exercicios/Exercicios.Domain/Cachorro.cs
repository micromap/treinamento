using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Exercicios.Domain
{
    public class Cachorro
    {       
        public string Latir()
        {
            return "Au! Au!";
        }

        // metrodo para calcular 5% do peso (Kg) do cachorro em gramas de Ração;
        public string QuantoDeveComer(int pesoKg)
        {            
            return $"Como tenho {pesoKg}kg, devo comer {pesoKg * 50.0}g por dia";           
        }

    }
}
