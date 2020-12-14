using System;
using System.Collections.Generic;
using System.Text;

namespace Aula07Sergio
{
    class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public override string ToString()
        {
            return $"Produto(codigo = { Codigo }, nome = {Nome}, preço = {Preco}, quantidade = {Quantidade})";
        }

        public override bool Equals(object obj)
        {
            var p = (Produto) obj;

            return Codigo == p.Codigo;
       
        }
    }
}
