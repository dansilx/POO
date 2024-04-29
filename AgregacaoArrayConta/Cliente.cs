using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoArrayConta
{
    public class Cliente
    {
        public string? Nome { get; set; }

        public string? Rg { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("Nome: " + Nome + "\tRG: " + Rg);
        }
    }
}