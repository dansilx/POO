using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoArrayConta{

    public class Conta
    {
        public int Numero { get; set; }
        public List<Cliente> VetTitulares { get; set; }
        public double Saldo { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("Número: " + Numero + "\tSaldo: " + Saldo);
        }
    }
}