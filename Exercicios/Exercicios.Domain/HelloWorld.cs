namespace Exercicios.Domain
{
    public static class HelloWorld
    {

        public static string SayHello()
        {
            return "HelloWorld";
        }

        public static void PassaValor(int valor)
        {
            valor = 999;
        }

        public static void AcessaMinhaClasse()
        {
            var obj = new MinhaClasse();
            //obj.MeuMetodo();
        }

    }
}
