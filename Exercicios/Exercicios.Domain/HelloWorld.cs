using System;
using System.Threading;
using System.Threading.Tasks;

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
            valor = 999;
        }

        public static void PassaReferencia(Cachorro cachorro)
        {
            cachorro.Nome = "Tequila";
        }

        public static string Tarefa(string tarefa, int passos)
        {
            Console.WriteLine($"## Tarefa {tarefa} INICIADA!");

            for(var i = passos; i > 0; i--)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"      >> Tarefa {tarefa} executando... {i}");
            }

            return $"## Tarefa {tarefa} CONCLUÍDA!";
        }

        public static async Task<string> TarefaAsync(string tarefa, int passos)
        {
            Console.WriteLine($"## Tarefa {tarefa} INICIADA!");

            for (var i = passos; i > 0; i--)
            {
                await Task.Delay(1000);
                Console.WriteLine($"      >> Tarefa {tarefa} executando... {i}");
            }

            return $"## Tarefa {tarefa} CONCLUÍDA!";
        }

    }
}