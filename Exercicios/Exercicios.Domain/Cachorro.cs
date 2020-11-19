using System;
using System.Collections.Generic;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Nome { get; set; }
        public Sexo Sexo { get; set; }
        public Raca Raca { set; get; }
        public string Porte { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public bool Vacinado { get; set; }
        public Dono Dono { get; set; }



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

        public List<string>  ValidarCampos()
        {
            var lista = new List<string> {};

            if (string.IsNullOrWhiteSpace(Nome))
                lista.Add("Nome do cachorro é obrigatório");    
                        
            if (DataDeNascimento > DateTime.Today)
                lista.Add("Data de Nascimento deve ser anterior ou igual a data de hoje");
            
            if (Peso <= 0)
                lista.Add("Peso deve ser maior que 0");

            return lista;
        }

        public void ValidarCamposException()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                throw new Exception("Nome do cachorro é obrigatório");
            }
            
           if (DataDeNascimento > DateTime.Today)
            {
                throw new Exception("Data de Nascimento deve ser anterior ou igual a data de hoje");
            }

            if (Peso <= 0)
            {
                throw new Exception ("Peso deve ser maior que 0");
            }               
            
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " " + "Dono: " + Dono;
        }
    }
}