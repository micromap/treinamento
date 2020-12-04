using System;
using System.Collections.Generic;

namespace Exercicios.Domain
{
    public class Cachorro : Animal, IPet
    {
        public Raca Raca { set; get; }
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

            for (var i = 1; i <= qtdeLatidos; i++)
                latidos += "Au! ";

            return latidos.TrimEnd();
        }

        // Método para calcular 5% do Peso(Kg) do cachorro em Gramas de Ração
        public override string QuantoDevoComer()
        {
            return $"Como tenho {Peso}kg, devo comer {Peso * 50}g por dia";
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

        public override void Validar()
        {
            var mensagens = ValidacoesComuns();

            if (DataNascimento > DateTime.Today)
                mensagens.Add("Data de Nascimento do Cachorro deve ser menor que Hoje!");

            if (Peso <= 0)
                mensagens.Add("Peso do Cachorro deve ser maior que zero!");

            var ex = Helpers.ConvertStringListToException(mensagens);
            if (ex != null)
                throw ex;

        }
    }
    
}