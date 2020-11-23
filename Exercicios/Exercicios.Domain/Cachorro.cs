using System;
using Microsoft.Win32.SafeHandles;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        
        public string Nome { set; get; }

        public string Sexo { set; get; }
        
        #region Raca
        public string Raca { set; get; }
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

        private string _raca;
        #endregion

        public string Porte { set; get; }

        public int Idade { set; get; }

        public bool Vacinado { set; get; }

        #region Peso
        public double? Peso
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
        #endregion

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
        public string QuantoDevoComer(int pesoKg)
        {
            int grama = pesoKg * 1000;

            double porcento = grama * 0.05;

            Console.WriteLine(porcento);

            //string saida = "Como tenho " + pesoKg.ToString() + "Kg,devo comer " + porcento.ToString() + "g por dia";
            string saida = $"Como tenho {pesoKg}Kg,devo comer {porcento}g por dia";  //  metodo de interpolar string

            return saida;
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
    }
}