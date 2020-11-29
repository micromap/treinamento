using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicios.Domain
{
    public class Cachorro : IPet
    {
        //ESTRUTURA DE PROPRIEDADES

        public string Nome { set; get; }

        public Sexo Sexo { set; get; }

        public string Foto { get; set; }

        public Dono Dono { set; get; }


        public Raca Raca { set; get; }

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
            for (var i = 1; i <= q_latidos; i++)
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
            var meses = DateTime.Today.Month - Nascimento.Month + (12 * anos);
            /*  if (idade > 1)
                  return $"{idade} anos";
                else
                  return $"{idade} ano"; */

            if (meses < 2)
                return $"{meses} mês";
            if (meses < 12)
                return $"{meses} meses";
            else
                return anos > 1 ? $"{anos} anos" : $"{anos} ano";


        }

        public void Validar()
        {
            var mensagens = new List<string>();

            if (string.IsNullOrWhiteSpace(Nome))
                mensagens.Add("Nome do pet é obrigatório!");

            if (Nascimento > DateTime.Today)
                mensagens.Add("Data de nascimento do pet deve ser menor que hoje!");

            if (Peso <= 0)
                mensagens.Add("Peso do pet deve ser maior que zero!");

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