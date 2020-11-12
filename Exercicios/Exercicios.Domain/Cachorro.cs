using System;
using System.Collections.Generic;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Raca { set; get; }
        public string Porte { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public bool Vacinado { get; set; }

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
        private double? _pesoKg;

        public string Latir(short qtdeLatidos)
        {
            var latidos = "";

            for(var i = 1; i <= qtdeLatidos; i++)
                latidos += "Au! ";

            return latidos.TrimEnd();
        }

        // Método para calcular 5% do Peso(Kg) do cachorro em Gramas de Ração
        public string QuantoDevoComer(int pesoKg)
        {
            return $"Como tenho {pesoKg}kg, devo comer {pesoKg * 50}g por dia";
        }

        public string CalcularIdade(DateTime dataNascimento)
        {
            var anos = DateTime.Today.Year - dataNascimento.Year;
            var meses = DateTime.Today.Month - dataNascimento.Month + (12 * anos);

            Console.WriteLine(meses);

            if (meses < 12)
                return (meses > 1) ? $"{meses} meses" : $"{meses} mês";
            else
                return (anos > 1) ? $"{anos} anos" : $"{anos} ano";
        }

        public List<string>  ValidarCampos(Cachorro cachorro)
        {
            var lista = new List<string> {};

            if (cachorro.Nome is null)
                lista.Add("Nome do cachorro é obrigatório");                
            
            if (cachorro.Sexo != "Macho" && cachorro.Sexo != "Fêmea")
                lista.Add("Sexo Inválido");
            
            if (cachorro.DataDeNascimento > DateTime.Today)
                lista.Add("Data de Nascimento deve ser anterior ou igual a data de hoje");
            
            if (cachorro.Peso <= 0)
                lista.Add("Peso deve ser maior que 0");

            return lista;
        }
    }
}