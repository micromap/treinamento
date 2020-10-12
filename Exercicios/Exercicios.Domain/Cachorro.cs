using System;
using System.Globalization;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        #region Latir
        public string Latir()
        {
            return "Au! Au!";
        }
        #endregion

        #region Quanto Devo Comer
        public string QuantoDevoComer(int peso)
        {
            //Método para Calcular 5% do peso do cachorro em gramas de ração.
            return $"Como tenho { peso }Kg, devo comer { peso * 50}g por dia";
        }
        #endregion

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

        #region Raça
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
        public void SetIdade(int idade_cao)
        {
            _idade = idade_cao;
        }

        public int GetIdade()
        {
            return _idade;
        }
        private int _idade;
        #endregion

        #region Peso
        public void SetPeso(double peso_cao)
        {
            if(peso_cao < 0)
            {
                _peso = 0;
            }
            else
            {
                _peso = peso_cao;
            }
            
        }

        public double GetPeso()
        {
            return _peso;
        }
        private double _peso;
        #endregion
    }
}
