using System;

namespace Exercicios.Domain
{   

    //Classe Cachorro
    public class Cachorro
    {
        //Atributos privados da classe, com os gets e sets de cada atributos... todos dentro da região de codigos de cada um.
        #region NOME
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

        #region SEXO
        private string _sexo;
        public string GetSexo()
        {
            return _sexo;
        }

        public void SetSexo(string sexo)
        {
            _sexo = sexo;
        }
        #endregion

        #region RACA
        private string _raca;
        public string GetRaca()
        {
            return _raca;
        }

        public void SetRaca(string raca)
        {
            _raca = raca;
        }
        #endregion

        #region PORTE
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

        #region IDADE
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

        #region PESOKG
        private double _pesoKg;
        public void SetPesoKg(double pesoKg)
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
        public double GetPesoKg()
        {
            return _pesoKg;
        }
        #endregion

        //Metodo da classe, Latir(), QuantoDevoComer()
        public string Latir()
        {
            return "Au! Au!";
        }

        public string QuantoDevoComer(int peso)
        {
            return $"Como tenho {peso}kg, devo comer {(peso*1000)*0.05}g por dia";
        }
    }
}