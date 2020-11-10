using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string  Raca {get; set;}
        public string Porte { get; set; }
        public int Idata { get; set;  }
        public string DataNascimento { get; set; }
        public double Peso { get; set; }
        public bool Vacinado { get; set; }

        /*
         public string Latir(string latir)
         { 
             return "Au! Au!"; 
         }
        */ 

        public string Latir(short quantidadeDeLatidos)
        {
            string latidos = "";
            for(short i =1; 1 <= quantidadeDeLatidos; i++)
            {
                latidos = latidos + "Au!";
            }
            return latidos;
        }


        public string QuantoDeveComer(int pesoKg)
        // metrodo para calcular 5% do peso (Kg) do cachorro em gramas de Ração;
        {
            return $"Como tenho {pesoKg}kg, devo comer {pesoKg * 50.0}g por dia";           
        }

        public List<string> Valida()
        {
           List<string> message = new List<string>();

            if (string.IsNullOrWhiteSpace(Nome))
                message.Add("Nome do cachorro é obrigatório!");

            return message.Count == 0 ? message : null;
        }
    }
}
