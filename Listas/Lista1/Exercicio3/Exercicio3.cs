using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Exercicio3
    {
        static void Main(string[] args)
        {
            var aux = Console.ReadLine();
            int x = Convert.ToInt32(aux);

            for(int i = 1; i <= x; i=i+2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
