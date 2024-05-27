using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributo
{
    public class ContaCorrente : ITributavel
    {
        public int Saldo { get; set; }

        public double calculaTributos() {
            return this.Saldo * 5/100;
        }
    }
}