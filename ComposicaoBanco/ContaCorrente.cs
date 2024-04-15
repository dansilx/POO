using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        public double Saldo { get; set; }

        private double chequeEspecial;
        public double ChequeEspecial {
            get {return chequeEspecial;}
            set {
                if(value < 0) {
                    System.Console.WriteLine("Não é permitido limite de cheque especial negativo!");
                } else {
                    chequeEspecial= value;
                }
            }
        }

        public ContaCorrente (double saldo, double cheque) {
            Saldo = saldo;
            ChequeEspecial = cheque;
        }

        public void Depositar (double valor) {
                Saldo += valor;  
        }

        public bool Sacar(double valor) {
            if (Saldo >= valor) {
                Saldo -= valor;
                return true;
            } else {
                double resto = Math.Abs(Saldo - valor);
                if (ChequeEspecial >= resto) {
                    Saldo -= valor;
                    return true;
                } else {
                    return false;
                }
            }
        }

        public void GerarExtrato() {
            System.Console.WriteLine("Extrato da Conta:");
            System.Console.WriteLine("\nSaldo: " + Saldo);
            System.Console.WriteLine("\nCheque Especial: " + ChequeEspecial);
        }
    }
}