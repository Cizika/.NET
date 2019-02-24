using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine("{0},cujo preço é $ {1:F2}", produto2, preco2);

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine();
            Console.WriteLine($"Media com oito casas decimais : {media:F8}");
            Console.WriteLine($"Arredondado( três casas decimais):{Math.Round(media, 3)}");
            Console.WriteLine($"Separador decimal invariant culture: {Math.Round(media, 3).ToString(CultureInfo.InvariantCulture)}");

        }
    }
}
