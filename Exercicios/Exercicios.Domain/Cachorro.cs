using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {

        private string _nome;
        private string _sexo;
        private string _raca;
        private string _porte;
        private int _idade;
        private double _pesoKg;

        public string Latir()
        {
            return "Au! Au!";
        }

        // Método para calcular 5% do Peso(kg) do cachorro em Gramas de Ração
        public string QuantoDevoComer(int pesoKg)
        {
            return $"Como tenho {pesoKg}kg, devo comer {pesoKg * 50}g por dia";
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public string GetNome()
        {
            return _nome;
        }
    }
}
