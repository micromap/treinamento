
using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        private string _nome;
        private string _sexo;
        private string _raca;
        private string _porte;
        private int    _idade;
        private double _peso;





        public string Latir()
        {
            return "au au au au!";
        }



        //Método para calcular 5% do peso do cachorro em ração, é o que ele deve comer.
        public string QuantoDevoComer(Double pesoCachorro)
        {
            this._peso = pesoCachorro;
            Double PesoAComer = pesoCachorro * 0.05;
            
            //cifrão na frente do texto e concatena usando chaves (Interpolação de string)
            return $"Como tenho {pesoCachorro}Kg, devo comer {PesoAComer}g por dia";
        }

        public double GetPeso()
        {
            return _peso;
        }

        public void SetPeso(int peso)
        {
            this._peso = peso;
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
            this._sexo = sexo;
        }

        public string GetSexo()
        {
            return this._sexo;
        }

        public void SetRaca(string raca)
        {
            this._raca = raca;
        }

        public string GetRaca()
        {
            return this._raca;
        }

        public void SetPorte(string porte)
        {
            this._porte = porte;
        }

        public string GetPorte()
        {
            return this._porte;
        }

        public void SetIdade(int idade)
        {
            this._idade = idade;
        }

        public int GetIdade()
        {
            return this._idade;
        }
    }
}
