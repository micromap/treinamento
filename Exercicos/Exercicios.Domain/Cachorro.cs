using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Nome { get; set; }
        public Sexo Sexo { get; set; }
        public Raca Raca { get; set; }
        public double Peso { get; set; }
        public bool Vacinado { get; set; }
        public DateTime DataNascimento { get; set; }
        public Dono Dono { get; set; }



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

        public void ValidarDadosCachorro()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                throw new Exception("Nome do Cachorro é Obrigatório");

            if (Sexo.Equals("Macho") && Sexo.Equals("Femea"))
                throw new Exception("Sexo Cachorro OK");

            if (DataNascimento > DateTime.Today)
                throw new Exception("Data de Nascimento do Cachorro deve ser menor que Hoje");

            if (Peso <= 0)
                throw new Exception("Peso do Cachorro deve ser maior que 0 (zero)");
        }
    }
}
