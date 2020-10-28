using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    // public class     => Acesso de dentro e fora do assembly
    // internal class   => Acesso apenas de dentro do assembly
    // class            => O mesmo que internal class
    class MinhaClasse
    {
        // public               => Acesso de dentro e fora do assembly
        // private              => Acesso de dentro da própria classe
        // internal             => Acesso de dentro do assembly
        // protected            => Acesso de dentro da própria classe e classes derivadas
        // protected internal   => Acesso de dentro da classe, e classes derivadas de dentro do assembly
        public void MeuMetodo()
        {
        }
    }
}
