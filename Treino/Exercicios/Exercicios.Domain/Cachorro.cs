
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
            this._sexo = sexo;
        }

        public string GetSexo()
        {
            return this._sexo;
        }
        private string _sexo;
        #endregion
        #region Raca
        public void SetRaca(string raca)
        {
            this._raca = raca;
        }

        public string GetRaca()
        {
            return this._raca;
        }
        private string _raca;
        #endregion
        #region Porte
        public void SetPorte(string porte)
        {
            this._porte = porte;
        }

        public string GetPorte()
        {
            return this._porte;
        }

        private string _porte;
        #endregion
        #region Idade
        public void SetIdade(int idade)
        {
            this._idade = idade;
        }

        public int GetIdade()
        {
            return this._idade;
        }
        private int    _idade;
        #endregion
        #region Peso
        public double GetPeso()
        {
            return _peso;
        }

        public void SetPeso(int peso)
        {
            if(peso < 0)
            {
                this._peso = 0;
            }
            else
            { 
                this._peso = peso;
            }
        }
        private double _peso;
        #endregion




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

       

       

       

       

        
      
    }
}
