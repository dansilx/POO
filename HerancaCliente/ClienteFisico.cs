using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{//classe derivada : classe base
    public class ClienteFisico : Cliente
    {   
        private string rg;
        
        public void Mostrar() {
            System.Console.WriteLine("Codigo: " + codigo + "\nNome: " + nome + "\nEndereço: " + endereco + "\nRg" + rg);
        }

         public string Rg{
            get { return rg; }
            set { rg = value; } 
        }
    }
}