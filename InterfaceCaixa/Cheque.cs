using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceCaixa
{
    public class Cheque : Pagamento
    {
        public long Numero { get; set; }
        public DateTime DataDeposito { get; set; }
        public int Situacao { get; set; }

        public Cheque(long numero, DateTime dataDeposito, int situacao, Venda vendido) : base(vendido) {
            this.Numero = numero;
            this.DataDeposito = dataDeposito;
            this.Situacao = situacao;
        }

        public override void MostrarPagamento() {
            base.MostrarPagamento();
            System.Console.WriteLine("Numero do Cheque: " + Numero);
            System.Console.WriteLine("Data do Depósito: " + DataDeposito.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Situação: " + Situacao);
        }
    }
}