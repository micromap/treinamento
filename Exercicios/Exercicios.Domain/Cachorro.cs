using System;
using System.Globalization;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        #region Latir
        public string Latir(short q_latidos)
        {
            string latidos = "";
            for(var i= 1; i <= q_latidos; i++)
                latidos += "Au! ";
            return latidos.TrimEnd();
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
        public void SetNome(string nome_cao)
        {
            _nome = nome_cao;
        }

        public string GetNome()
        {
            return _nome;
        }
        private string _nome;
        #endregion

        #region Sexo
        public void SetSexo(string sexo_cao)
        {
            _sexo = sexo_cao;
        }

        public string GetSexo()
        {
            return _sexo;
        }
        private string _sexo;
        #endregion

        #region Raça
        public void SetRaca(string raca_cao)
        {
            _raca = raca_cao;
        }

        public string GetRaca()
        {
            return _raca;
        }
        private string _raca;
        #endregion

        #region Porte
        public void SetPorte(string porte_cao)
        {
            _porte = porte_cao;
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
        public void SetPeso(double? peso)
        {
            if(peso < 0)
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
    }
}
