using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
        }

        static void Exercicio1()
        {
            Console.WriteLine("Digite o ângulo:");
            double angulo = double.Parse(Console.ReadLine());
            double radianos = (angulo * Math.PI) / 180;

            double seno = Math.Round(Math.Sin(radianos), 4);
            double cosseno = Math.Round(Math.Cos(radianos), 4);


            Console.WriteLine("Seno " + seno + " e Cosseno " + cosseno);
        }

        static void Exercicio2()
        {
            string frase = Console.ReadLine();

            if (frase.Length > 2)
            {
                frase = frase.ToLower();
                frase = frase.Replace("a", "");
                frase = frase.Replace("e", "");
                frase = frase.Replace("i", "");
                frase = frase.Replace("o", "");
                frase = frase.Replace("u", "");

                Console.WriteLine(frase);


            }
            else
            {
                Console.WriteLine("String precisa ter tamanho maior que 1");
            }
        }

        static void Exercicio3()
        {

            string texto = Console.ReadLine();
            int lindex = texto.LastIndexOf("b", StringComparison.CurrentCultureIgnoreCase);
            int index = texto.IndexOf("b", StringComparison.CurrentCultureIgnoreCase);
            string subtexto = texto.Substring(index, lindex - index+1);

            Console.WriteLine("Começa no índice: "+index);
            Console.WriteLine("Foi encontrado a sequência: "+subtexto);
            Console.WriteLine("Tamanho: "+subtexto.Length);

        }

        static void Exercicio4()
        {
            string textdata =Console.ReadLine();
            Console.WriteLine("1-Somar anos\n2-Somar meses\n3-Somar dias\n4-Somar horas\n5-Somar minutos\n6-Somar segundos");

            DateTime data = DateTime.Parse(textdata);

            int x = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            switch (x)
            {

                case 1:
                   data = data.AddYears(num);
                    break;
                case 2:
                    data = data.AddMonths(num);
                    break;
                case 3:
                    data = data.AddDays(num);
                    break;
                case 4:
                     data = data.AddHours(num);
                    break;
                case 5:
                    data = data.AddMinutes(num);
                    break;
                case 6:
                    data = data.AddSeconds(num);
                    break;
                    
            }

            Console.WriteLine(data);

        }
    }
}
