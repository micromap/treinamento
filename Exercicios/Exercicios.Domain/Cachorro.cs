﻿using System;
using System.IO.Pipes;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Nome { get; set; } 
        public string Sexo { get; set; }
        public string Raca { get; set; }
        public string Porte { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Vacinado { get; set; }

        private double? _pesoKg;
        public double? Peso
        {
            set
            {
                if (value < 0)             
                    _pesoKg = null;
                else
                    _pesoKg = value;
            }
            get
            {
                return _pesoKg;
            }
        }

        public string Latir(short quantidadeLatidos)
        {
            var latidos = "";

            for(var i=1; i<=quantidadeLatidos; i++)
                latidos +=  "Au! ";   //ou latidos = latidos + "Au! ";

            return latidos.TrimEnd();
        }

        public string QuantoDevoComer(int pesoKg)
        {
            double qtdeRacaoGramas = pesoKg * 50;

            return $"Como tenho {pesoKg}kg, devo comer {qtdeRacaoGramas}g por dia.";
        }
        public string GetIdade()
        {
            var anos = DateTime.Now.Year - DataNascimento.Year;
            var meses = DateTime.Now.Month - DataNascimento.Month + (12 * anos);

           // return (idade > 1) ? $"{idade} anos" : "1 ano";  //se verdade ? retorna : se não

            if (anos < 1 && meses != 1)
            {
                return $"{meses} meses";
            }
            else if (anos < 1 && meses == 1)
            {
                return "1 mês";
            } 
            else if(anos > 1)
            {
                return $"{anos} anos";
            }
            else
            {
                return "1 ano";
            }
        }
    }
}
