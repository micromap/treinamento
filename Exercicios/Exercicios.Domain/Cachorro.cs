using System;
using System.Dynamic;

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
        private bool _vacinado;

        //Metodo criado pelo VS a partir do auto sugestao.
        public string Latir(short quantidade_latidos)
        {
            string latidos = "";

            for(int i = 0; i < quantidade_latidos; i++)
            {
                latidos += "Au! ";
            }

            return latidos;
        }

        public double QuantoDevoComer(int peso, double porcIdeal)
        {
            return peso * (1+(porcIdeal/100));
        }

        //Getters and Setters

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }
        
        public string GetSexo()
        {
            return _sexo;
        }

        public void SetSexo(string sexo)
        {
            _sexo = sexo;
        }

        public string GetRaca()
        {
            return _raca;
        }

        public void SetRaca(string raca)
        {
            _raca = raca;
        }

        public string GetPorte()
        {
            return _porte;
        }

        public void SetPorte(string porte)
        {
            _porte = porte;
        }

        public int GetIdade()
        {
            return _idade;
        }

        public void SetIdade(int idade)
        {
            _idade = idade;
        }

        public double GetPeso()
        {
            return _peso;
        }

        public void SetPeso(double peso)
        {
            _peso = peso;
        }

        public bool GetVacinado()
        {
            return _vacinado;
        }

        public void SetVacinado(bool vacinado)
        {
            _vacinado = vacinado;
        }

        public string GetVacinadoFormatado()
        {
            return (_vacinado == true ? "Sim" : "Não");
        }
    }
}
