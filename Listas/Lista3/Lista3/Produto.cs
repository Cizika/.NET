using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3
{
    class Produto
    {
        public string Nome
        {
            get; private set;
        }
        public int Codigo
        {
            get; private set;
        }
        public int Quantidade
        {
            get;set;
        }

        private double preco;
        

        public double Preco
        {
            get
            {
                return this.preco;
            }

            set
            {

                if (value > 0)
                    this.preco = value;
            }
            
        }
        

        public Produto(string Nome,int Codigo,int Quantidade, double Preco)
        {
            this.Nome = Nome;
            this.Codigo = Codigo;
            this.Quantidade = Quantidade;
            this.preco = Preco;
        }

        public double ValorTotal()
        {
           return this.Preco * this.Quantidade;
        }
    }
}
