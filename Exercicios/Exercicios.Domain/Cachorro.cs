using System;

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
        public void SetRaca(string raca)
        {
            _raca = raca;
        }

        public string GetRaca()
        {
            return _raca;
        }
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

        #region Peso
        public void SetPeso(double? peso)
        {
            if (peso < 0)
            {
                _peso = null;
            }
            else
            {
                _peso = peso;
            }
        }

        public double? GetPeso()
        {
            return _peso;
        }
        private double? _peso;
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
