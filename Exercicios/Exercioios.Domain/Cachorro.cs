using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        private string _nome;
        private string _sexo;
        private string _raca;
        private string _porte;
        private int _idade;
        private double _peso;

        public string Latir()
        {
            return "Au! Au!";
        }

        public string QuantoDevoComer(int peso)
        {
            double qtdeRacao = peso * 0.10;
            string mensagem = "Como tenho " + peso +
                              "Kg, devo comer " + qtdeRacao +
                              "kg por dia";
            return mensagem;
        }

        public string QuantoIreiPesar(int peso)
        {
            double pesoFuturo =peso - (peso * 0.10);
            string mensagem = "Como tenho " + peso +
                              "Kg atualmente, daqui 10 anos irei pesar " + pesoFuturo + "kg";

            return mensagem;
        }

        public string QualMinhaIdade(int idade)
        {
            int idadeFutura = idade + 5;
            string mensagem = "Como tenho " + idade + " anos de idade, daqui 5 anos vou ter " + idadeFutura + " anos";

            return mensagem;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public string GetNome()
        {
            return _nome;

        }

        public void SetSexo(string sexo)
        {
            _sexo = sexo;
        }

        public string GetSexo()
        {
            return _sexo;
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
            return _porte;
        }
    }
}

