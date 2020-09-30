using System;
using System.Globalization;

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
            //Método para Calcular 5% do peso do cachorro em gramas de ração.
            return $"Como tenho { peso }Kg, devo comer { peso * 50}g por dia";
        }

    }
}
