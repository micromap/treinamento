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

        public void SetLatido(int v)
        {
            throw new NotImplementedException();
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
        private double? _pesoKg;
        public void SetPeso(double? pesoKg)
        {
            if (pesoKg < 0)
            {
                _pesoKg = null;
            }
            else
            {
                _pesoKg = pesoKg;
            }
        }
        public double? GetPeso()
        {
            return _pesoKg;

        }
        #endregion

        #region Vacinado
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

        public string Latir(short quantidadeLatidos)
        {
            var latidos = "";

            for(var i=1; i<=quantidadeLatidos; i++)
                latidos +=  "Au! ";   //ou latidos = latidos + "Au! ";

            return latidos.TrimEnd();
        }

        public string QuantoDevoComer(int pesoKg)
        {
            double qtdeRacaoGramas = pesoKg * 50;

            return $"Como tenho {pesoKg}kg, devo comer {qtdeRacaoGramas}g por dia.";
        }
    }

}
