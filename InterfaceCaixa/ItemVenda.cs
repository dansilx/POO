using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceCaixa
{
    public class ItemVenda
    {
        public double Preco { get; set; }
        public double Subtotal { get; private set; }
        private Produto prod;
        public Produto Prod { 
            get { return prod; }
            set {
                prod = value;
                Subtotal = prod.Preco = Quantidade;
            }
        }

        private int quantidade = 0;
        public int Quantidade {
            get { return quantidade; }
            set {
                quantidade = value;
                Subtotal = prod.Preco  * Quantidade;
            }
        }
        
        public ItemVenda(Produto prod, int quantidade) {
            this.Prod = prod;
            this.Quantidade = quantidade;
            this.Subtotal = prod.Preco * Quantidade;
        }

        public void exibirItem() {
            System.Console.WriteLine($"Produto: {prod.Nome}\tQuantidade: {quantidade}\tSubtotal: {Subtotal:c}");
        }
        
    }
}