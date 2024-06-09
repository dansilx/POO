using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceCaixa
{
    public class Venda
    {
        public DateTime Data { get; set; }
        public double Total { get; set; }
        public List<ItemVenda> ItensVenda { get; private set; }
        public Pagamento Pagamento { get; set; }

        public Venda(DateTime data) {
            this.Data = data;
            this.Total = 0;
            this.ItensVenda = new List<ItemVenda>();
        }
        
        public void AdicionarItem(ItemVenda item) {
            ItensVenda.Add(item);
            Retotalizar();
        }

        public void RemoverItem(ItemVenda item) {
            ItensVenda.Remove(item);
            Retotalizar();
        }

        private void Retotalizar() {
            double total = 0;
            foreach (ItemVenda item in ItensVenda)
            {
                total += item.Subtotal;
            }
            Total = total;
        }

        public void AplicarDescontoAtacado() {
            if (ItemVenda.Quantidade >= 50) {
                double desconto = Total * 0.20;
                Total -= desconto;  
            }
        }

        public void MostrarVenda()
        {
            System.Console.WriteLine($"Data: {Data.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Total: {Total:c}");
            System.Console.WriteLine("----- Itens -----");
            foreach (ItemVenda item in ItensVenda)
            {
                item.MostrarItem();
            }
        }
    }
}