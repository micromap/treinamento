using System;

namespace Exercicios.Domain
{
    public class MinhaClasse
    {
        // public => Acesso de dentro e fora do assembly
        // private => Acesso de dentro da própria classe
        // interno => Acesso de dentro do assembly
        // protected => Acesso de dentro da própria classe e classes derivadas
        // protected internal => Acesso de dentro da classe, e classes derivadas de dentro do assembly
        public void MeuMetodo()
        {

        }
        
        public void OutroMetodo()
        {
          this.MeuMetodo();
        }

        public class ClasseFilha : MinhaClasse
        {
           public void MetodoFilho()
           {
             this.MeuMetodo();
           }
        }
        public class ClasseFilha2 : MinhaClasse
        {
            public void MetodoFilho2()
            {
                this.MeuMetodo();
            }
        }
    }
}
