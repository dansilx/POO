using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNF { get; set; }
        public string Data { get; set; }
        public List<ItemNotaFiscal> VetItens { get; set; }

        public NotaFiscal(int numNF, string data) {
            NumeroNF = numNF;
            Data =  data;
            VerItens = new List<ItemNotaFiscal>();
        }

        public void AdicionarItens(ItemNotaFiscal itens) {
            VetItens.Add(itens);
        }
    }
}