using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    public class MinhaClasse
    {

         protected internal void MeuMetodo()
        {

        }
        public void OutroMetodo()
        {
            this.MeuMetodo();
        }
    }

    public class ClasseFilha : MinhaClasse
    {
        public void MetodoFilho()
        {
            this.MeuMetodo();
        }
    } 
}
