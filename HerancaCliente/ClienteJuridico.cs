using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteJuridico : Cliente
    {  
        private string cnpj;

        public string Cnpj{
            get { return cnpj; }
            set { cnpj = value; }
        }
    }
}