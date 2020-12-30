using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicios.Domain
{
    public class Cachorro : Animal, IPet
    {
        //ESTRUTURA DE PROPRIEDADES

        public Raca Raca { set; get; }

        public string Porte { set; get; }

        public DateTime Nascimento { set; get; }

        public bool Vacinado { set; get; }

        public string Latir(short q_latidos)
        {
            string latidos = "";
            for (var i = 1; i <= q_latidos; i++)
                latidos += "Au! ";
            return latidos.TrimEnd();
        }

        public override string QuantoDevoComer()
        {
            //Método para Calcular 5% do peso do cachorro em gramas de ração.
            return $"Como tenho {Peso }Kg, devo comer { Peso * 50}g por dia";
        }

        public String GetIdade()
        {
            var anos = DateTime.Today.Year - Nascimento.Year;
            var meses = DateTime.Today.Month - Nascimento.Month + (12 * anos);
       
            if (meses <= 2)
                return $"{meses} mês";
            if (meses < 12)
                return $"{meses} meses";
            else
                return anos > 1 ? $"{anos} anos" : $"{anos} ano";


        }

        public override void Validar()
        {
            var mensagens = ValidacoesComuns();

            if (Nascimento > DateTime.Today)
                mensagens.Add("Data de nascimento do pet deve ser menor que hoje!");

            if (Peso <= 0)
                mensagens.Add("Peso do pet deve ser maior que zero!");

            var ex = ListExtensions.ToException(mensagens);
            if (ex != null)
                throw ex;

        }



    }
}