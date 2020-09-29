namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Latir()
        {
            return "Au Au!";
        }

        public string QuantoDevoComer(int pesoKg)
        {
            double qtdeRacaoGramas = pesoKg * 50;

            return $"Como tenho {pesoKg}kg, devo comer {qtdeRacaoGramas}g por dia.";
        }
    }

}
