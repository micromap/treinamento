using System;
using System.Collections.Generic;

namespace Exercicios.Domain
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public Sexo Sexo { get; set; }
        public string Foto { get; set; }
        public Dono Dono { get; set; }

        private double? _pesoKg;
        public double? Peso
        {
            set
            {
                if (value < 0)
                    _pesoKg = null;
                else
                    _pesoKg = value;
            }
            get
            {
                return _pesoKg;
            }
        }

        public abstract string QuantoDevoComer();
        protected virtual List<string> ValidacoesComuns() 
        {
            var mensagens = new List<string>();

            if (string.IsNullOrWhiteSpace(Nome)) 
                mensagens.Add("Nome do Pet é Obrigatório!");

            return mensagens;
        }
        public virtual void Validar() //virtual herda, mas pode ter uma versão específica
        {
            var mensagens = ValidacoesComuns();
            var ex = mensagens.ToException(); 
                throw ex;
        }
    }
}
