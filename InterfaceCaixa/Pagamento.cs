using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceCaixa
{
    public abstract class Pagamento
    {
        public Venda Vendido { get; set; }
        public DateTime Data { get; set; }
        public double Total { get; set; }

        public Pagamento(Venda vendido) {
            this.Vendido = vendido;
            this.Data = DateTime.Now;
            this.Total = vendido.Total;
        }

        public virtual void MostrarPagamento()
        {
            System.Console.WriteLine("Data: " + this.Data.ToString("dd/MM/yyyy"));
            System.Console.WriteLine($"Total: {this.Total:c}");
            System.Console.WriteLine("Itens:");
            foreach (ItemVenda v in this.Vendido.ItensVenda)
            {
                v.MostrarItem();
            }
        }
    }
}