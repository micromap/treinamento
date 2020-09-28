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
            return "Au! Au! teste";
        }

        public double quantoDevoComer(int peso)
        {
            double result = ((peso * 1000) * 5 / 100);

            return result;
        }
    }
}
