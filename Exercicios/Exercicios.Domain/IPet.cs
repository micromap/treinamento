using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    public interface IPet
    {
        string Nome { get; set; }
        string Foto { get; set; }
        Sexo Sexo { get; set; }
        Dono Dono { get; set; }

        string QuantoDevoComer(int peso);

        void Validar();

    }
}
