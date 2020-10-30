using System;
using System.ComponentModel;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        private string Nome { get; set; }
        private string Sexo { get; set; }
        private string Raca { get; set; }
        private string Porte { get; set; }
        private double Peso { get; set; }
        private bool Vacinado { get; set; }
        private DateTime DataNascimento { get; set; }


        public string Latir(short quantidade)
        {
            string result = "";

            for (int i = 0; i < quantidade; i++)
            {
                result += "Au! ";
            }

            return result;
        }

        public double quantoDevoComer(int peso)
        {
            double result = ((peso * 1000) * 5 / 100);

            return result;
        }

        public string idade(DateTime dataNascimento)
        {
            string result = "";
            
            TimeSpan dataaux = DateTime.Today.Subtract(dataNascimento);

            double idade = Math.Truncate(dataaux.TotalDays / 365);

            if (idade < 1)
                result = $"Cachorro tem {idade} Mese(s)";
            else
                result = $"Cachorro tem {idade} Ano(s)";

            return result;
        }
    }
}
