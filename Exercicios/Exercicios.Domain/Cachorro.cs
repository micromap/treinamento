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
        public void SetPeso(double peso)
        {
            if (peso < 0)
            {
                _peso = 0;
            }
            else
            {
                _peso = peso;
            }
        }

        public double GetPeso()
        {
            return _peso;
        }
        private double _peso;
        #endregion

        public string Latir()
        {
            return "Au! Au!";
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
