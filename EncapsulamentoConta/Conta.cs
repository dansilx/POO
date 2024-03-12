using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        private int numero;
        private string? titular;
        private double saldo;

        public int Numero //propriedade
        {
            set {
                this.numero = value;
            }

            get {
                return this.numero;
            }

        }

        /*public  void SetNumero(int numeroConta) //alterar numeros
        {  
            numero = numeroConta;
        }

        public int GetNumero() // buscar numeros
        {
            return numero;
        }
        public  void AlterarNumero(int numeroConta)
        {  
            numero = numeroConta;
        }

        public int BuscarNumero()
        {
            return numero;
        }*/
    }
}