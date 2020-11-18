using System;

namespace Exercicios.domain
{
    public class Cachorro
    {
        private const string V = ";;
         private string _nome;
        private string _sexo;
        private string _raca;
        private string _porte;
        private int _idade;
        private double _pesokg;


        public string Latir()
        {
            return "Au Au!";
        }

        public string QuantoDevoComer(string peso)
        {
            int quantidade = peso;
            return "Devo Comer" + quantidade;
        }
        public string Nome
        {
            set
            {
                _nome = value;
            }
            get
            {
                return _nome;
            }
        }
         public string Raca
        {
            set
            {
                _raca = value;
            }
            get
            {
                return _raca;
            }
        }
        public string Porte
        {
            set
            {
                _porte = value;
            }
            get
            {
                return _porte;
            }
            
        public DateTime datanascimento { get; set; }

        public string GetIdade()
        {
            
        }
    }

       
    }
}
