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
            _peso = peso;
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

        public string QuantoDevoComer(int peso, string nome)
        {
            return $"{nome} pesando {peso}Kg deve comer {peso * 1000 * 0.05}g diariamente.";

            #region TiposConcatenação
            // teste de concatenação
            //return string.Join("", nome, " pesando ", peso, "Kg deve comer ", (peso * 1000) * (0.05), "g diariamente.");
            //return $"{nome} pesando {peso}Kg deve comer {(peso * 1000) * (0.05)}g diariamente.";
            //return string.Format("{0}{1}{2}{3}{4}{5}", nome," pesando ", peso,"Kg deve comer ", (peso * 1000) * (0.05), "g diariamente.");
            #endregion
        }
    }
}
