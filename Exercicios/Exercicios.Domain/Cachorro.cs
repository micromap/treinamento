using System;
using System.Dynamic;

namespace Exercicios.Domain
{
    public class Cachorro
    {

        //para gerar uma propriedade automatica usar esse comando : prop<TAB> <TAB> ai vai escrever o comando abaixo
        //public string MyProperty { get; set; } 

        //Essa é uma propriedade automática
        public string Nome { set; get; }

        //#region Nome essa forma é a mais analítica para escrever esse comando e acima é usando propriedades fica mais sintetico economiza linhas de códigos
        //public void SetNome(string nome)
        //{
        //    _nome = nome;
        //}
        //public string GetNome()
        //{
        //    return _nome;
        //}
        //private string _nome;
        //#endregion
      
        public string Sexo { set; get; }
        
        //#region Sexo
        //public void SetSexo(string sexo)
        //{
        //    _sexo = sexo;
        //}
        //public string GetSexo()
        //{
        //    return _sexo;
        //}
        //private string _sexo;
        //#endregion

        public string Raca { set; get; }        
        public string Porte { set; get; }                
        public int Idade { set; get; }        
        public bool Vacinado { set; get; }
        // como nesse método tem regras de negócio não da para simplificar como nas propriedades acima. não da pra ser uma propriedade automática
        #region Peso
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
        #endregion
        
                
        public string Latir(short qtdeLatidos)
        {
            var latidos = "";

            for(var i = 1; i <= qtdeLatidos; i++)
            //{ se o for tiver somente uma linha de comando pode-se omitir as chaves {}
                //latidos = latidos + "Au! "; abaixo outra forma de escrever essa linha
                latidos += "Au! ";
            //} se o for tiver somente uma linha de comando pode-se omitir as chaves {}
            return latidos.TrimEnd();
        }

        public string QuantoDevoComer(int pesoKg)
        
        {
            
            //Método para calcular 5% do Peso(Kg) do cachorro em gramas de Ração
            return $"Como tenho {pesoKg}Kg, devo comer {pesoKg * 50}g por dia";

            // Esse é um jeito mais discriminado de fazer a rotina
            //double qtdeRacaoGramas = pesoKg * 1000 * 0.05;
            //string mensagem = "Como tenho " + pesoKg.ToString() +
            //                  "Kg, devo comer " +  qtdeRacaoGramas.ToString() +
            //                  "g por dia";
        }

        
    }
  
}
