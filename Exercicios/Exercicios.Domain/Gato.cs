using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    public class Gato : IPet
    {
        public string Nome { get; set; }
        public string Foto { get; set; }
        public Sexo Sexo { get; set; }
        public Dono Dono { get; set; }

        public string QuantoDevoComer(int peso)
        {
            throw new NotImplementedException();
        }

        public void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
