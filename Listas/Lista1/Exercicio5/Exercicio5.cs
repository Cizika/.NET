using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Exercicio5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro Valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("Operação: ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Segundo Valor: ");
            //var valor2 = Convert.ToDouble(Console.ReadLine());




            switch (op)
            {
                case '+':
                    Console.WriteLine(valor1 + valor2); break;
                case '-': Console.WriteLine(valor1 - valor2); break;

                case '*': Console.WriteLine(valor1 * valor2); break;

                case '/': if(valor2 == 0)
                    {
                        Console.WriteLine("É impossivel dividir por 0"); break;
                    }
                    Console.WriteLine(valor1 / valor2); break;

                default: Console.WriteLine("Operação inválida"); break;

            }

        }
    }
}
