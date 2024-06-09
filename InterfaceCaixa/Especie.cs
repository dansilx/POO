using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceCaixa
{
    public class Especie : Pagamento
    {
        private double quantia;
        public double Quantia {
            get { return quantia;;}
            set {
                quantia = value;
                if (vase.Vendido != null)
                    Troco = quantia - base.Vendido.Total;
                else
                    Troco = quantia;
            }
        }
        public double Troco { get; {return Quantidade - Total} }

        public Especie (double quantia, Venda vendido) : base(vendido) {
            this.Quantia = quantia;
            if (vendido != null)
                Troco = quantia - vendido.Total;
        }

        public override void MostrarPagamento() {
            base.MostrarPagamento();
            System.Console.WriteLine("Tipo de Pagamento: Espécie");
            System.Console.WriteLine($"Quantia: {Quantia:c}");
            System.Console.WriteLine($"Troco: {Troco:c}");
        }
    }
}