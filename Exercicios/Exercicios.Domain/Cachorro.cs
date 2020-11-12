using System;

namespace Exercicios.Domain
{
    public class Cachorro
    
    {
        #region nome
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

        #region sexo
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

        #region raca
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

        #region porte
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

        #region idade
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

        #region peso
        public void SetPeso(double peso)
        {
            if (peso < 0)
            {
                _pesoKg = 0;
            }
            else
            { 
                _pesoKg = peso;
            }
        }

        public double GetPeso()
        {
            return _pesoKg;
        }
        private double _pesoKg;
        #endregion

        #region vacinado
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

        public string latir(short qtdeLatidos)
        {
            string latidos = "";

            for (short i = 1; i <= qtdeLatidos; i++)
            {
                latidos = latidos + "Au! ";
            }

            return latidos.TrimEnd();
        }

        public string QuantoDevoComer(int pesoKg)
        {
            return $"Como tenho {pesoKg} Kg, devo comer {pesoKg * 50} g por dia";
        }

    }
}
