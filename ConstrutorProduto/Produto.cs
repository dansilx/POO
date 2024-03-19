using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorProduto
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public static int Quantidade { get; set; }

        public Produto(int codigo)
        {
            Codigo = codigo;
            Quantidade ++;
        }

        public Produto(string nome)
        {
            Nome = nome;
            Quantidade ++;
        }

        public Produto(double preco)
        {
            Preco = preco;
            Quantidade ++;
        }
    }
}