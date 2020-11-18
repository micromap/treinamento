using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using Exercicios.Domain;

namespace Exercicios.Test
{
    [TestClass]
    public class ExemplosTest
    {
        [TestMethod]
        public void Exception_Test()
        {
            try 
            {    var x = 10;
                var y = 0;
                var result = x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não pode ter divisão por Zero");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Fim do Teste");
            }
        }
    }
}
