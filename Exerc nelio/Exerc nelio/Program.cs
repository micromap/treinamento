using System;
using System.Globalization;


namespace Exerc_nelio { 

    class Program {
        static void Main(string[] args)
        {

            retangulo x = new retangulo();

        x.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("AREA = " + x.area().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("PERIMETRO = " + x.perimetro().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("DIAGONAL = " + x.diagonal().ToString("F2", CultureInfo.InvariantCulture));
        Console.ReadLine();
        }
    }

}
