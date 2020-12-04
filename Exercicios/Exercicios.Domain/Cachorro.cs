using System;
using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;

namespace Exercicios.Domain
{
    public class Cachorro : Animal, IPet
    {
        public Raca Raca { set; get; }
        /*
           A opção da linha de cima é chamada de automatico e as linha abaixos são os comandos que internamente o C# faz para nós
         * { set
            {
                _raca = value;
            }

            get
            {
                return _raca;
            }
        }*/

        public int Idade { set; get; }
        public bool Vacinado { set; get; }
        
        public DateTime DataNascimento { get; set; }

        public string Latir(short qtdeLatidot )
        {
            string latidos = "";

            for (var i = 1; i <= qtdeLatidot; i++)
            {
                //latidos = latidos + "Au! ";   A linha de baixa é um linha mais resumida
                latidos += "Au! ";
            }
            return latidos.TrimEnd();
        }

        // Método para Calcular 5% do Peso (Kg) do cachorro em gramas de ração
        public override string QuantoDevoComer()
        {
            //string saida = "Como tenho " + pesoKg.ToString() + "Kg,devo comer " + porcento.ToString() + "g por dia";
            return $"Como tenho {Peso}Kg,devo comer {Peso * 50}g por dia";  //  metodo de interpolar string

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
            // if  (nome == null || Nome = "" || Nome = "   ")   || quer dizer OR

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