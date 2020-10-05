using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        #region Nome
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

        #region Sexo
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

        #region Raça
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

        #region Porte
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

        #region Idade
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

        #region Peso
        private double _pesoKg;
        public void SetPeso(double pesoKg)
        {
            if (pesoKg < 0)
            {
                _pesoKg = 0;
            }
            else
            {
                _pesoKg = pesoKg;
            }
        }
        public double GetPeso()
        {
            return _pesoKg;

        }
        #endregion

        public string Latir()
        {
            return "Au Au!";
        }

        public string QuantoDevoComer(int pesoKg)
        {
            double qtdeRacaoGramas = pesoKg * 50;

            return $"Como tenho {pesoKg}kg, devo comer {qtdeRacaoGramas}g por dia.";
        }        
    }

}
