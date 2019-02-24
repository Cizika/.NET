using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            const string senha = "2002";
            string tentativa;
            int cont = 0;
            while (cont == 0)
            {
                tentativa = Console.ReadLine();
                if(tentativa != senha)
                {
                    Console.WriteLine("Senha Invalida");
                }
                else {
                    Console.WriteLine("Acesso Permitido");
                    cont++;
                }

            }
        }
    }
}
