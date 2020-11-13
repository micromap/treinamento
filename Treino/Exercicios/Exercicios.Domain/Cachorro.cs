
using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public Double Peso;
        public string nome; 




        public string Latir()
        {
            return "au au au au!";
        }



        //Método para calcular 5% do peso do cachorro em ração, é o que ele deve comer.
        public string QuantoDevoComer(Double pesoCachorro)
        {
            this.Peso = pesoCachorro;
            Double PesoAComer = pesoCachorro * 0.05;
            
            //cifrão na frente do texto e concatena usando chaves (Interpolação de string)
            return $"Como tenho {pesoCachorro}Kg, devo comer {PesoAComer}g por dia";
        }
    }
}
