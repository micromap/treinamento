using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    public interface IPet
    {
        string Nome { get; set; }
        SexoEnum Sexo { get; set; }
        string Foto { get; set; }
        Dono Dono { get; set; }

        string QuantoDevoComer(int pesoKg);

        void Validar();
    }
}
