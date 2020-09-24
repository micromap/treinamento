using System;

namespace Aula02
{
    class Produto
    {
        public int codigo;
        public string nome;
        public int quantidade;
        public double preco;
        public DateTime validade;

        public Produto() //construtor alterado
        {
            codigo = -1;
            nome = "A Definir";
            quantidade = -1;
            preco = -1.0;
        }

        public Produto(int codigo, string nome, int quantidade, double preco, DateTime validade) //construtor com parâmetro
        {
            this.codigo = codigo; //1°codigo = da classe    2°codigo = parâmetro
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
            this.validade = validade;
        }

        public Produto(string nome, int quantidade)
        {
            this.nome = nome;
            this.quantidade = quantidade;

        }

    }


}
