using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public class ClienteFisico : Cliente
    {
         private string rg;
        public ClienteFisico() : base(){

        }
        public ClienteFisico(int codigo, string nome, string endereco, string rg) : base (codigo, nome, endereco)
        {
            Rg = rg;
        }
        public override void Mostrar() {
            //base.Mostrar();
            //System.Console.WriteLine("RG: " + rg);
            System.Console.WriteLine("Código: " + codigo + "\nNome: " + nome + "\nEndereço: " + endereco + "\nRG: " + rg);    
        }

         public string Rg{
            get { return rg; }
            set { rg = value; } 
        }
    }
}