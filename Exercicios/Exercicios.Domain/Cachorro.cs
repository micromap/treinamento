using System;
using System.Globalization;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        #region Latir
        public string Latir(short q_latidos)
        {
            string latidos = "";
            for(var i= 1; i <= q_latidos; i++)
                latidos += "Au! ";
            return latidos.TrimEnd();
        }
        #endregion

        #region Quanto Devo Comer
        public string QuantoDevoComer(int peso)
        {
            //Método para Calcular 5% do peso do cachorro em gramas de ração.
            return $"Como tenho { peso }Kg, devo comer { peso * 50}g por dia";
        }
        #endregion

        #region Nome
        public string Nome { set; get; }
        #endregion

        #region Sexo

        public string Sexo { set; get; }
        #endregion

        #region Raça
        //ESTRUTURA DE PROPRIEDADES
        public string Raca { set; get; }
        #endregion

        #region Porte

        public string Porte { set; get; }
        #endregion

        #region Idade

        public int Idade { set; get; }
     
        #endregion

        #region Peso

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
        public bool Vacinado { set; get; }
        #endregion
    }
}
