using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        //declaração dos atributos
        public int codigo;
        public string? nome;
        public double preco;

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
    }
}