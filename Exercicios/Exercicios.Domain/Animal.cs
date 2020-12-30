using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public Sexo Sexo { get; set; }
        public string Foto { get; set; }
        public Dono Dono { get; set; }
        public double? Peso
        {
            set
            {
                if (value < 0)
                    _peso = null;
                else
                    _peso = value;
            }
            get
            {
                return _peso;
            }
        }

        private double? _peso;

        public abstract string QuantoDevoComer();
       
        protected List<string> ValidacoesComuns()
        {
            var mensagens = new List<string>();

            if (string.IsNullOrWhiteSpace(Nome))
                mensagens.Add("Nome do pet é obrigatório!");

            return mensagens;          
        }

        public virtual void Validar()
        {
            var mensagens = ValidacoesComuns();
            var ex = Helpers.CovertStringListToException(mensagens);
            if (ex != null)
                throw ex;
        }
    }
}
