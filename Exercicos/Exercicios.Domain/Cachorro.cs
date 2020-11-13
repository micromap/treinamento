using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Raca { get; set; }
        public string Porte { get; set; }
        public double Peso { get; set; }
        public bool Vacinado { get; set; }
        public DateTime DataNascimento { get; set; }


        public string Latir(short quantidade)
        {
            string result = "";

            for (int i = 0; i < quantidade; i++)
            {
                result += "Au! ";
            }

            return result;
        }

        public double quantoDevoComer(int peso)
        {
            double result = ((peso * 1000) * 5 / 100);

            return result;
        }

        public string idade(DateTime dataNascimento)
        {
            string result = "";

            var anos = DateTime.Today.Year - dataNascimento.Year;
            var meses = DateTime.Today.Month - dataNascimento.Month + (12 * anos);

            if (meses == 1)
                result = $"Cachorro tem {meses} Mês";
            else if (meses < 12)
                result = $"Cachorro tem {meses} Meses";
            else if (anos == 1)
                result = $"Cachorro tem {anos} Ano";
            else
                result = $"Cachorro tem {anos} Anos";

            return result;
        }

        public List<string> validarDadosCachorro()
        {
            var listaValidar = new List<string>();

            if (string.IsNullOrWhiteSpace(Nome))
                listaValidar.Add("Nome do Cachorro é Obrigatório");
            else
                listaValidar.Add("Nome Cachorro OK");

            if (Sexo.Equals("Macho") || Sexo.Equals("Femea"))
                listaValidar.Add("Sexo Cachorro OK");
            else
                listaValidar.Add("Sexo do Cachorro Inválido");

            if (DataNascimento > DateTime.Today)
                listaValidar.Add("Data de Nascimento do Cachorro deve ser menor que Hoje");
            else
                listaValidar.Add("Data Nascimento Cachorro OK");

            if (Peso <= 0)
                listaValidar.Add("Peso do Cachorro deve ser maior que 0 (zero)");
            else
                listaValidar.Add("Peso Cachorro OK");

            return listaValidar.Count == 0 ? null : listaValidar;
        }
    }
}
