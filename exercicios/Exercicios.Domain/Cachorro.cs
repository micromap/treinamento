using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        private string nome;
        private char sexo;
        private string raca;
        private string porte;
        private int idade;
        private double peso;


        public string Latir()
        {
            return "Au! Au!";
        }
        
        public string QuantoDeveComer(int pesoKg)
        // metrodo para calcular 5% do peso (Kg) do cachorro em gramas de Ração;
        {
            return $"Como tenho {pesoKg}kg, devo comer {pesoKg * 50.0}g por dia";           
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }
    }
}
