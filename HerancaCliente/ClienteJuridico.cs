using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteJuridico : Cliente
    {  
        private string cnpj;

        public int Cnpj{
            get { return cnpj; }
            set { cnpj = value; }
        }
    }
}