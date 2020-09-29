using System;
using System.ComponentModel;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        private string _nome;
        private string _sexo;
        private string _raca;
        private string _porte;
        private int _idade;
        private double _peso;

        public string latir()
        {
            return "Au! Au!";
        }

        public double quantoDevoComer(int peso)
        {
            double result = ((peso * 1000) * 5 / 100);

            return result;
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

        public string GetRaxa()
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

        public void SetIdade(int idade)
        {
            _idade = idade;
        }

        public int GetIdade()
        {
            return _idade;
        }

        public void SetPeso(double peso)
        {
            _peso = peso;
        }

        public double GetPeso()
        {
            return _peso;
        }
       
    }
}
