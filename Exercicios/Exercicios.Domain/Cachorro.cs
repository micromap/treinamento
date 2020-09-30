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

        // Método para calcular 5% do Peso(Kg) do cachorro em Gramas de Ração
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

        public string GetSexo()
        {
            return _sexo;
        }

        public void SetSexo(string sexo)
        {
            _sexo = sexo;
        }

        public void SetRaca(string raca)
        {
            _raca = raca;
        }

        public void SetPorte(string porte)
        {
            _porte = porte;
        }

        public void SetIdade(int idade)
        {
            _idade = idade;
        }

        public void SetPesoKg(double pesoKg)
        {
            _pesoKg = pesoKg;
        }

        public string GetRaca()
        {
            return _raca;
        }

        public string GetPorte()
        {
            return _porte;
        }

        public int GetIdade()
        {
            return _idade;
        }

        public double GetPesoKg()
        {
            return _pesoKg;
        }
    }
}