using System;
using System.ComponentModel;

namespace Exercicios.domain
{
    public class Cachorro
    {
        public string Nome { set; get; }
        public string Sexo { set; get; }
        public Raca Raca { set; get; }
        public Dono Dono { set; get; } 
        public string Porte { set; get; }
        public int Idade { set; get; }
        public bool Vacinado { get; set; }
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

        public string Latir(short qtdelatidos)
        {

            var latidos = "";

            for (var i = 1; i <= qtdelatidos;i++)
                latidos += "AU! ";
            
            return latidos.TrimEnd();
        }
        public string QuantoDevoComer(int peso)
        {
            return $"Como tenho {peso}kg, devo comer {(peso*1000) * 0.05}g por dia";
        }
    }
}