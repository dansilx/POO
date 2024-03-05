using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta//toda classe é um tipo de dado
    {
        //declaração dos atributos
        public int numero;
        public string titular;
        public double saldo;
        //declaração de métodos
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero +
            "\tTitular: " + titular + "\tSaldo: "
            + saldo);
        }
        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
        }
        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }
    }
}