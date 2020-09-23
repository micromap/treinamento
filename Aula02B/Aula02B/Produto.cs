using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02B
{
    class Produto
    {
        private int codigo;
        private string nome;
        private double preco;
        private DateTime data;

        // Como vou utilizar o construtor padrão, não preciso defini-lo
        // Beleza? Olhe na Aula1 caso tenha dúvidas


        // A Propriedade deve ser publica, já o campo acima pode ser private
        // Aqui segue um exempli de definição de propriedade na "UNHA", na classe Pessoa já existe o automático
        public int Codigo 
        {
            //GET é a permissão de leitura
            // SET é a permissão de escrita        
            set
            {
                codigo = value;
            }

            get
            {
                return codigo ;
            }
        }

    }
}
