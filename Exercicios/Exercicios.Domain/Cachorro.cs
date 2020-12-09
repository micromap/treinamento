
using System;
using System.Collections.Generic;
using System.IO.Pipes;

namespace Exercicios.Domain
{
    public class Cachorro : Animal, IPet
    {
      
        public Raca Raca { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Vacinado { get; set; }
        
        public string Latir(short quantidadeLatidos)
        {
            var latidos = "";

            for(var i=1; i<=quantidadeLatidos; i++)
                latidos +=  "Au! ";   //ou latidos = latidos + "Au! ";

            return latidos.TrimEnd();
        }

        public override string QuantoDevoComer()  //override permite especificar no filho
        {
            return $"Como tenho {Peso}kg, devo comer {Peso * 50}g por dia.";
        }
        public string GetIdade()
        {
            var anos = DateTime.Now.Year - DataNascimento.Year;
            var meses = DateTime.Now.Month - DataNascimento.Month + (12 * anos);

           // return (idade > 1) ? $"{idade} anos" : "1 ano";  //se verdade ? retorna : se não

            if (anos < 1 && meses != 1)
            {
                return $"{meses} meses";
            }
            else if (anos < 1 && meses == 1)
            {
                return "1 mês";
            } 
            else if(anos > 1)
            {
                return $"{anos} anos";
            }
            else
            {
                return "1 ano";
            }
        }
        
        public override void Validar()
        {
            var mensagens = ValidacoesComuns();

            if(string.IsNullOrWhiteSpace(Nome)) // if(Nome == null || Nome == "" || Nome == "  ") retorna thrue
                mensagens.Add("Nome do Pet é Obrigatório!");

            if (DataNascimento > DateTime.Today)
                mensagens.Add("Data de nascimento deve ser menor que hoje!");

            if (Peso <= 0)
                mensagens.Add("Peso deve ser maior que zero!");

            var ex = mensagens.ToException();
            if (ex != null)
                throw ex;
        }
    }
}
