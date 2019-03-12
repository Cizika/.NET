using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Insira o nome do Produto:"); string nome = Console.ReadLine();
            Console.WriteLine("Insira o código do Produto: ");int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a Quantidade no Estoque: ");int quant = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Preço do Produto: ");double preco = double.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome,codigo,quant,preco);
            Console.WriteLine("-------------------------Produto---------------");
            Console.WriteLine("Nome: "+p1.Nome);
            Console.WriteLine("Codigo: " + p1.Codigo);
            Console.WriteLine("Quantidade em estoque: " + p1.Quantidade);
            Console.WriteLine("Preco: " + p1.Preco);
            Console.WriteLine("Valor Total: " + p1.ValorTotal());
            Console.WriteLine("-----------------------------------------------");

        }

        
    }
}
