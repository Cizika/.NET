using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Exercicio4
    {
        static void Main(string[] args)
        {

            double salario = Convert.ToDouble(Console.ReadLine());
            
            double imposto=0;

            if (salario <= 2000.00)
            {
                Console.WriteLine("ISENTO");
            }
            else if (salario <= 3000.00)
            {
                imposto = (salario - 2000.00) * 8 / 100;
            }
            else if (salario <= 4500.00)
            {
                imposto = (salario - 3000.00) * 18 / 100;
                imposto += 80;
            }
            else
            {
                imposto = (salario - 4500.00) * 28 / 100;
                imposto += 350;
            }

            Console.WriteLine($"R$ {imposto:F2}");
        }
    }
}
