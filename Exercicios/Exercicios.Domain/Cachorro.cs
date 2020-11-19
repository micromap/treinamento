using System;
using Microsoft.Win32.SafeHandles;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        #region Nome
        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public string GetNome()
        {
            return _nome;
        }
        private string _nome;
        #endregion

        #region Sexo
        public void SetSexo(string sexo)
        {
            _sexo = sexo;
        }

        public string GetSexo()
        {
            return _sexo;
        }
        private string _sexo;
        #endregion

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

        #region Porte
        public void SetPorte(string porte)
        {
            _porte = porte;
        }

        public string GetPorte()
        {
            return _porte;
        }
        private string _porte;
        #endregion

        #region Idade
        public void SetIdade(int idade)
        {
            _idade = idade;
        }

        public int GetIdade()
        {
            return _idade;
        }
        private int _idade;
        #endregion

        #region Vacinado
        public void SetVacinado(bool vacinado)
        {
            _vacinado = vacinado;
        }

        public bool GetVacinado()
        {
            return _vacinado;
        }
        private bool _vacinado;
        #endregion

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
        
    }
}