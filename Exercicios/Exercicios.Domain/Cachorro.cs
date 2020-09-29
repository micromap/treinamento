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

        public string QuantoDevoComer(int peso)
        {
            return $"Como tenho {peso}kg, devo comer {(peso*1000)*0.05}g por dia";
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

        public string GetRaca()
        {
            return _raca;
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

        public int GetIdade()
        {
            return _idade;
        }

        public void SetPesoKg(double pesoKg)
        {
            _pesoKg = pesoKg;
        }

        public double GetPesoKg()
        {
            return _pesoKg;
        }

        public string GetPorte()
        {
            return _porte;
        }
    }
}