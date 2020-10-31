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
        public DateTime DataNascimento { get; set; }
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

        public string GetIdade()
        {
            var anos = DateTime.Today.Year - DataNascimento.Year;
            var meses = DateTime.Today.Month - DataNascimento.Month + (12 * anos);

            if (meses < 12)
                return meses > 1 ? $"{meses} meses" : "1 mês";
            else
                return anos > 1 ? $"{anos} anos" : "1 ano";
        }

        public List<string> Validar()
        {
            var mensagens = new List<string>();

            if (string.IsNullOrWhiteSpace(Nome))
                mensagens.Add("Nome do Cachorro é Obrigatório!");

            if (Sexo != "Fêmea" && Sexo != "Macho")
                mensagens.Add("Sexo do Cachorro deve ser Fêmea ou Macho!");

            if (DataNascimento > DateTime.Today)
                mensagens.Add("Data de Nascimento do Cachorro deve ser menor que Hoje!");

            if (Peso <= 0)
                mensagens.Add("Peso do Cachorro deve ser maior que zero!");

            return mensagens.Count == 0 ? null : mensagens;
        }
    }
}