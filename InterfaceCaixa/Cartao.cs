using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceCaixa
{
    public class Cartao : Pagamento
    {
        public string DadosTransacao { get; set; }
        public int ResultadoTransacao { get; set; }

        public Cartao(string dadosTransacao, int resultadoTransacao,Venda vendido) : base(vendido) {
            this.DadosTransacao = dadosTransacao;
            this.ResultadoTransacao = resultadoTransacao;
        }

        public override void MostrarPagamento() {
            base.MostrarPagamento();
            System.Console.WriteLine("Dados da Transação: " + DadosTransacao);
            System.Console.WriteLine("Resultado da Transação: " + ResultadoTransacao);
        }
    }
}