using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02B
{
    class Produto
    {
        private int codigo;
        public int Codigo
        {
            get
            {
                return  codigo;
            }
            set
            {
                codigo = value;
            }
        
        }
        private string nome;
        public string Nome
        {
            get
            {
                return  nome;
            }
            set
            {
                nome = value;
            }

        }
        private double preco;
        public double Preco
        {
            get
            {
                return  preco;
            }
            set
            {
                preco = value;
            }

        }
        private int quantidade;
        public int Quantidade
        {
            get
            {
                return  quantidade
                    ;
            }
            set
            {
                quantidade = value;
            }

        }
        private DateTime validade;
        public DateTime Validade
        {
            get
            {
                return validade;
            }
            set
            {
                validade = value;
            }

        }

    }
}
