using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public class ClienteJuridico : Cliente
    {
        private string cnpj;

        public ClienteJuridico() : base() {
            
        }
        public ClienteJuridico(int codigo, string nome, string endereco, string cnpj) : base (codigo, nome, endereco)
        {   
            Cnpj = cnpj;
        }

        public string Cnpj{
            get { return cnpj; }
            set { cnpj = value; }
        }

        public override void Mostrar() {
            //base.Mostrar();
            //System.Console.WriteLine("CNPJ: " + Cnpj);
             System.Console.WriteLine("Código: " + codigo + "\nNome: " + nome + "\nEndereço: " + endereco + "\nCNPJ: " + Cnpj);
        }
    }
}