using System;
using System.Globalization;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        private string _nome;
        private string _sexo;
        private string _raca;
        private string _porte;
        private int    _idade;
        private double _peso;


        public string Latir()
        {
            return "Au! Au!";
        }

      
        public string QuantoDevoComer(int peso)
        {
            //Método para Calcular 5% do peso do cachorro em gramas de ração.
            return $"Como tenho { peso }Kg, devo comer { peso * 50}g por dia";
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetSexo(string sexo)
        {
            _sexo = sexo;
        }

        public string GetSexo()
        {
            return _sexo;
        }

        public void SetRaca(string raca)
        {
            _raca = raca;
        }

        public string GetRaca()
        {
            return _raca;
        }

        public void SetPorte(string porte)
        {
            _porte = porte;
        }

        public string GetPorte()
        {
            return _porte;
        }

        public void SetIdade(int idade_cao)
        {
            _idade = idade_cao;
        }

        public int GetIdade()
        {
            return _idade;
        }

        public void SetPeso(double peso_cao)
        {
            _peso = peso_cao;
        }

        public double GetPeso()
        {
            return _peso;
        }
    }
}
