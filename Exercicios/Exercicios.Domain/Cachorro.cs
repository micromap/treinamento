using System;
using System.Collections.Generic;

namespace Exercicios.Domain
{   

    //Classe Cachorro
    public class Cachorro
    {
        //Propriedades da Classe 
        public string Nome { set; get; }

        public string Sexo { set; get; }

        public string Raca { set; get; }

        public string Porte { set; get; }

        public DateTime DataNascimento { get; set; }

        public bool Vacinado { set; get; }
        
        #region PesoKG
        public double? PesoKg
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
        #endregion _pesoKg

        //Metodo da classe, Latir(), QuantoDevoComer()
        public string Latir(short quantidadeLatidos)
        {
            var latidos = "";

            for(var i = 1; i <= quantidadeLatidos; i++) // Caso dentro do for so tenha uma linha de comando, pode deixar sem as {}.       
                latidos += "Au! "; //Atribuição composta, substitui latidos = latidos + "Au! "

            return latidos.TrimEnd(); // Comando TrimEnd() tira o espaço em branco no final da string
        }

        public string QuantoDevoComer(int peso)
        {
            return $"Como tenho {peso}kg, devo comer {(peso*1000)*0.05}g por dia";
        }

        public object GetIdade()
        {
            var anos = DateTime.Today.Year - DataNascimento.Year;
            var meses = DateTime.Today.Month - DataNascimento.Month + (12 * anos);

            if (meses < 12)
                return meses > 1 ? $"{meses} meses" : $"{meses} mes";
            else
                return anos > 1 ? $"{anos} anos" : $"{anos} ano";
        }

        public void Validar()
        {
            var mensagens = new List<string>();

            if(string.IsNullOrWhiteSpace(Nome))
                mensagens.Add("Nome do cachorro é obrigatório!!");

            if(Sexo != "Femea" && Sexo != "Macho")
                mensagens.Add("Sexo do cachorro deve ser Femea ou Macho!!");

            if (DataNascimento > DateTime.Today)
                mensagens.Add("A data de nascimento do cachorro, deve menor que hoje!!");

            if (PesoKg <= 0 )
                mensagens.Add("Peso do cachorro deve ser maior que zero!!");

            if(mensagens.Count > 0)
            {
                var exceptionMessage = "";
                foreach (var msg in mensagens)
                    exceptionMessage += msg + Environment.NewLine;

                throw new Exception(exceptionMessage);
            }
        }
    }
}