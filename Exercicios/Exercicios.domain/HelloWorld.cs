using System;

namespace Exercicios.domain
{
    public static class HelloWorld
    {
        public static string SayHello()
        {
            return "Hello World!";
        }

        public static void PassaValor(int valor)
        {
            valor = 999;
        }

        public static void PassaReferencia(Cachorro cachorro)
        {
            cachorro.Nome = "Tequila";
        }

        
    }
}
