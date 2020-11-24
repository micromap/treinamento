using System;

namespace Exercicios.Domain
{
    public class Cachorro
    
    {
        public string Nome { set; get; }
        public string Sexo { get; set; }
        public string Raca { set; get; }
        public string Porte { set; get; }
        public DateTime DataNascimento { get; set; }
        public bool Vacinado { set; get; }

        #region peso
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
        #endregion

        public string latir(short qtdeLatidos)
        {
            var latidos = "";

            for (var i = 1; i <= qtdeLatidos; i++)
                latidos += "Au! ";

            return latidos.TrimEnd();
        }

        public string QuantoDevoComer(int pesoKg)
        {
            return $"Como tenho {pesoKg} Kg, devo comer {pesoKg * 50} g por dia";
        }

        public string GetIdade()
        {
            var anos = DateTime.Today.Year - DataNascimento.Year;
            var meses = DateTime.Today.Month - DataNascimento.Month + (12 * anos);

            if (meses < 12)
                return meses > 1 ? $"{meses} meses" : "1 mês";
            else
                return anos > 1 ? $"{anos} anos" : "1 ano";

            //if (idade > 1)
            //    return $"{idade} anos";
            //else
            //    return "1 ano";

        }
    }
}
