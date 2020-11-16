using System;

namespace Exercicios.Domain
{
    public static class HelloWorld
    {
        public static string SayHello()
        {
            return "Hello World!";
        }

        public static void PassaValor(int valor)
        {
           
        }

        public static void PassaReferencia(Cachorro cachorro)
        {
            cachorro.SetNome("Tequila");
        }

        public static void AcessoMinhaClasse ()
        {
            var obj = new MinhaClasse();
            obj.MeuMetodo();
        }
            
    }
}
