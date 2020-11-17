using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Nome { set; get; }

        public string Sexo { set; get; }

        public string Raca { set; get; }

        public string Porte { set; get; }
        
        public int Idade { set; get; }

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

        public string Latir(short quantidadeLatidos)
        {
            string latidos = "";

            for (short i = 1; i <= quantidadeLatidos; i++) 
            { 
                latidos += "Au! ";
            }
            
            return latidos.TrimEnd();
        }

        public string QuantoDevoComer(int peso, string nome)
        {
            return $"{nome} pesando {peso}Kg deve comer {peso * 1000 * 0.05}g diariamente.";

            #region TiposConcatenação
            // teste de concatenação
            //return string.Join("", nome, " pesando ", peso, "Kg deve comer ", (peso * 1000) * (0.05), "g diariamente.");
            //return $"{nome} pesando {peso}Kg deve comer {(peso * 1000) * (0.05)}g diariamente.";
            //return string.Format("{0}{1}{2}{3}{4}{5}", nome," pesando ", peso,"Kg deve comer ", (peso * 1000) * (0.05), "g diariamente.");
            #endregion
        }
    }
}
