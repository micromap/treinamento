using System;
using System.ComponentModel;

namespace Exercicios.domain
{
    public class Cachorro
    {
        #region nome
        private string _nome;
        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public string GetNome()
        {
            return _nome;
        }
        #endregion

        #region sexo
        private string _sexo;
        public void SetSexo(string sexo)
        {
            _sexo = sexo;
        }

        public string GetSexo()
        {
            return _sexo;
        }
        #endregion

        #region raca
        private string _raca;
        public void SetRaca(string raca)
        {
            _raca = raca;
        }

        public string GetRaca()
        {
            return _raca;
        }
        #endregion
        
        #region porte
        private string _porte;
        public void SetPorte(string porte)
        {
            _porte = porte;
        }

        public string GetPorte()
        {
            return _porte;
        }
        #endregion

        #region idade
        private int _idade;
        public void SetIdade(int idade)
        {
            _idade = idade;
        }

        public int GetIdade()
        {
            return _idade;
        }
        #endregion

        #region peso
        private double _peso;
        public void SetPeso(Double peso)
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
        #endregion

        #region vacinado
        private bool _vacinado;
        public void SetVacinado(bool vacinado)
        {
            _vacinado = vacinado;
        }

        public bool GetVacinado()
        {
            return _vacinado;
        }
        #endregion

        #region latir
        public string Latir()
        {
            return "AU! AU!";
        }
        #endregion

        #region devo_comer
        public string QuantoDevoComer(int peso)
        {
            return $"Como tenho {peso}kg, devo comer {(peso*1000) * 0.05}g por dia";
        }
        #endregion
    }
}
