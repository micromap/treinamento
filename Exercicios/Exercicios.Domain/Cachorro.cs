using System;
using System.Globalization;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        //ESTRUTURA DE PROPRIEDADES

        public string Nome { set; get; } 
        public string Sexo { set; get; }     
        public string Raca { set; get; }
        public string Porte { set; get; }
        public DateTime Nascimento { set; get; }
        public bool Vacinado { set; get; }

        public double? Peso
        {
            set
            {
                if (value < 0)
                    _peso = null;
                else
                    _peso = value;
            }
            get
            {
                return _peso;
            }
        }
        private double? _peso;
          
        public string Latir(short q_latidos)
        {
            string latidos = "";
            for(var i= 1; i <= q_latidos; i++)
                latidos += "Au! ";
            return latidos.TrimEnd();
        }

        public string QuantoDevoComer(int peso)
        {
            //Método para Calcular 5% do peso do cachorro em gramas de ração.
            return $"Como tenho { peso }Kg, devo comer { peso * 50}g por dia";
        }

        public String GetIdade()
        {
            var anos = DateTime.Today.Year - Nascimento.Year;
            var meses = DateTime.Today.Month - Nascimento.Month+(12 * anos);
            /*  if (idade > 1)
                  return $"{idade} anos";
                else
                  return $"{idade} ano"; */

            if (meses < 2)
                return $"{meses} mês";
            if (meses < 12)
                return $"{meses} meses";
            else
            return anos > 1? $"{anos} anos": $"{anos} ano";
            

        }
    }
}
