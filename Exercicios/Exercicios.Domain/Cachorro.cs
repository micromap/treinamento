using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public void SetNome(string nome)
        {
            _nome = nome;
        }
        public string GetNome()
        {
            return _nome;
        }
        private string _nome;


        public void SetSexo(string sexo)
        {
            _sexo = sexo;
        }
        public string GetSexo()
        {
            return _sexo;
        }
        
        private string _sexo;
        private string _raca;
        private string _porte;
        private int _idade;
        private double _peso;

        public string Latir()
        {
            return "Au! Au!";
        }

        public string QuantoDevoComer(int pesoKg)
        
        {
            
            //Método para calcular 5% do Peso(Kg) do cachorro em gramas de Ração
            return $"Como tenho {pesoKg}Kg, devo comer {pesoKg * 50}g por dia";

            // Esse é um jeito mais discriminado de fazer a rotina
            //double qtdeRacaoGramas = pesoKg * 1000 * 0.05;
            //string mensagem = "Como tenho " + pesoKg.ToString() +
            //                  "Kg, devo comer " +  qtdeRacaoGramas.ToString() +
            //                  "g por dia";
        }

        
    }
  
}
