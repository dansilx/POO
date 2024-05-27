using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributo
{
    public class TotalizadorDeTributos
    {
        public double Total { get; set; }

        public void Adiciona(ITributavel tributavel) {
            this.Total += tributavel.calculaTributos();
        }
    }
}