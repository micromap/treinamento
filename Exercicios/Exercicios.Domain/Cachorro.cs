using System;
using System.Collections.Generic;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Nome { get; set; }
        public Sexo Sexo { get; set; }
        public Raca Raca { set; get; }
        public Dono Dono { set; get; }
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
        public string Latir(short qtdLatidos)
        {
            var latidos = "";

            for (var i = 1; i <= qtdLatidos; i++)
                latidos += "Au! ";

            return latidos.TrimEnd();
        }
        // Método para calcular 5% do Peso(kg) do cachorro em Gramas de Ração
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

        public void Validar()
        {
            var mensagens = new List<string>();

            if (string.IsNullOrWhiteSpace(Nome))
                mensagens.Add("Nome do Cachorro é Obrigatório!");
            if (DataNascimento > DateTime.Today)
                mensagens.Add("Data de Nascimento do Cachorro deve ser menor que Hoje!");
            if (Peso <= 0)
                mensagens.Add("Peso do Cachorro deve ser maior que zero!");
            if (mensagens.Count > 0)
            {
                var exceptionMessage = "";
                foreach (var msg in mensagens)
                    exceptionMessage += msg + Environment.NewLine;
                throw new Exception(exceptionMessage);
            }
        }
    }
}
