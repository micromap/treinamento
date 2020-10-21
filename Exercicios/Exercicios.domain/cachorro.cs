using System;

namespace Exercicios.domain
{
   public class Cachorro
    {
        private string _nome;
        private string _sexo;
        private string _raca;
        private string _porte;
        private int    _idade;
        private double _pesokg;


        public string Latir()
        {
            return "Au Au!";         
        }

        public string QuantoDevoComer(int peso)
        {
            double quantidade = peso * 1000 * 0.05;
            return "Devo Comer : " + quantidade;
        }


        public void SetNome(string nome)
        {
            _nome = nome;

        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetRaca(string raca)
        {
            _raca = raca;
        }

        public string GetRaca()
        {
            return _raca;
        }

        public void SetPorte(string porte)
        {
            _porte = porte;
        }

        public string GetPorte()
        {
            return _raca;
        }
    }
}
