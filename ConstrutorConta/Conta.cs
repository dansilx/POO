using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta() //construtor padrão
        {

        }

        public Conta(int numero)
        {
            Numero = numero;
        }

        public Conta(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {Numero} \tTitular: {Titular} \tSaldo: {Saldo:c}");
        }
    }
}