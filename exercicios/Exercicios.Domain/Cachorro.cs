using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string  Raca {get; set;}
        public string Porte { get; set; }
        public int Idata { get; set; }
        public double Peso { get; set; }

        public string Latir()
        {
            return "Au! Au!";
        }
        
        public string QuantoDeveComer(int pesoKg)
        // metrodo para calcular 5% do peso (Kg) do cachorro em gramas de Ração;
        {
            return $"Como tenho {pesoKg}kg, devo comer {pesoKg * 50.0}g por dia";           
        }     
    }
}
