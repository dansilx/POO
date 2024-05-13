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
        public ClienteFisico(int codigo, string nome, string endereco, int idade, string rg) : base (codigo, nome, endereco, idade)
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

        public override void AvaliaIdade() {
            if (Idade >= 18 && Idade < 40) {
                System.Console.WriteLine("Cliente Físico!");
            }
        }
    }
}