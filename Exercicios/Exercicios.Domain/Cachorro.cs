using System;

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

        public int Idade { set; get; }

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
    }
}