using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto
    {
        public int codigo;
        public string? nome;
        public double preco;
        public int quantidade;

        //declaração dos métodos
        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {codigo} \tNome: {nome} \tPreço: {preco:c}");
        }
        public void CalcularAumento(double porcentagem)
        {
            preco = preco + (preco * porcentagem/100);
            //preco += preco * porcentagem/100;
        }

        public double ValorTotalEstoque()
        {
            double totalEstoque = preco * quantidade;
            return totalEstoque;
        }

        public int removerEstoque(int quantidadeRemovida)
        {
            quantidade = quantidade - quantidadeRemovida;
        }
    }
}