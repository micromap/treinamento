
using System;
using Microsoft.Win32.SafeHandles;

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

        // Método para Calcular 5% do Peso (Kg) do cachorro em gramas de ração
        public string QuantoDevoComer(int pesoKg)
        {
            string saida = "";
            int grama = pesoKg * 1000;

            double porcento = grama * 0.05;

            Console.WriteLine(porcento);

            saida = "Como tenho "+ pesoKg +"Kg,devo comer "+ porcento +"g por dia";

            return saida;
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
    }
}
