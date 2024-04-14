using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        public double Comissao { get; set; }

        public void MostrarAtributos() {
            System.Console.WriteLine($"Comissão do Vendedor: {this.Comissao:c}");
        }
    }
}