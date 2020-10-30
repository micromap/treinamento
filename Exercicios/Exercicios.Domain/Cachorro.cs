using System;
using System.Runtime.ConstrainedExecution;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Raca { get; set; }
        public string Porte { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public bool Vacinado { get; set; }

        public string Latir(short qtdeLatidos)
        {
            string latidos = "";

            for(short i = 1; i <= qtdeLatidos; i++)
                latidos += "Au! ";

            return latidos.TrimEnd();
        }

        public string QuandoDevoComer(int peso)
        {
            return $"Como tenho {peso}kg, devo comer {((peso * 1000) * 5 / 100)}g por dia";
        }

        public Cachorro()
        {

        }

        public Cachorro(string nome, string sexo, string raca, string porte, int idade, double peso) 
        {
            Nome  = nome;
            Sexo  = sexo;
            Raca  = raca;
            Porte = porte;
            Idade = idade;
            Peso  = peso;
        }

    }
}

