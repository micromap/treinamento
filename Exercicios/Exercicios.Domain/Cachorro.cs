using System;
using System.Dynamic;

namespace Exercicios.Domain
{
    public class Cachorro
    {

        public string Nome  { set; get; }
        public Sexo Sexo    { get; set; }
        public Raca Raca    { set; get; }
        public string Porte { set; get; }
        public int Idade    { set; get; }
        public double Peso  { set; get; }
        public bool Vacinado { set; get; }

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

        //Getters and Setters personalizados
        public string GetVacinadoFormatado()
        {
            return (Vacinado == true ? "Sim" : "Não");
        }
    }
}
