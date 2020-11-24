using System;
using System.ComponentModel;

namespace Exercicios.domain
{
    public class Cachorro
    {
        public string Raca { set; get; }

        public string Porte { set; get; }

        public string Sexo { set; get; }

        public string Nome { set; get; }
      
        public int Idade { set; get; }

        #region peso
        public double? Peso
        {
            set
            {
                if (value < 0)
                    _peso = null;
                else
                    _peso = value;
            }
            get
            {
                return _peso;
            }

        }
        private double? _peso;

        #endregion

        #region Vacinado
        public bool Vacinado
        {

            set 
            {
                _vacinado = value;
            }
        
            get
            {
                return _vacinado;
            }
        }
        private bool _vacinado;
        #endregion

        #region latir
        public string Latir(short qtdelatidos)
        {

            var latidos = "";

            for (var i = 1; i <= qtdelatidos;i++)
                latidos += "AU! ";
            
            return latidos.TrimEnd();
        }
        #endregion

        #region devo_comer
        public string QuantoDevoComer(int peso)
        {
            return $"Como tenho {peso}kg, devo comer {(peso*1000) * 0.05}g por dia";
        }
        #endregion
    }
}