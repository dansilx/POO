using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        public List<Poupanca> Poupancas { get; set; }
        public List<ContaCorrente> Contas { get; set; }

        public Banco(){}

        public void IniciarBanco() {
            this.Poupancas = new List<Poupanca>();
            this.Contas = new List<ContaCorrente>();

            ContaCorrente c1 = new ContaCorrente(100,100);
            Contas.Add(c1);
            ContaCorrente c2 = new ContaCorrente(200,200);
            Contas.Add(c2);
            ContaCorrente c3 = new ContaCorrente(300,300);
            Contas.Add(c3);
            ContaCorrente c4 = new ContaCorrente(400,400);
            Contas.Add(c4);

            Poupanca p1 = new Poupanca(100);
            Poupancas.Add(p1);
            Poupanca p2 = new Poupanca(200);
            Poupancas.Add(p2);
            Poupanca p3 = new Poupanca(300);
            Poupancas.Add(p3);
            Poupanca p4 = new Poupanca(400);
            Poupancas.Add(p4);

            MostrarAtributos();
        }

        public void AbrirConta(double saldo, double limiteCheque) {
            ContaCorrente conta = new ContaCorrente(saldo, limiteCheque);
            Contas.Add(conta);
        }

        public void AbrirPoupanca(double saldo) {
            Poupanca poupanca = new Poupanca(saldo);
            Poupancas.Add(poupanca);
        }

        public void DecretarFalencia() {
            Poupancas = null;
            Contas = null;
        }

        public void MostrarContas() {
            foreach (ContaCorrente conta in Contas) {
                conta.GerarExtrato();
            }
        }

        public void MostrarPoupancas() {
            foreach (Poupanca poupanca in Poupancas) {
                poupanca.MostrarAtributos();
            }
        }

        public double CalcularSaldoContas() {
            double saldo = 0;
            foreach (ContaCorrente conta in Contas)
            {
                saldo += conta.Saldo;
            }

            return saldo;
        }

        public double CalcularSaldoPoupancas() {
            double saldo = 0;
            foreach (Poupanca poupanca in Poupancas)
            {
                saldo += poupanca.Saldo;
            }
            return saldo;
        }

        public void MostrarAtributos(){

            if(Contas == null || Poupancas == null)
            {
                System.Console.WriteLine("Banco em Falência");
            }
            else{
                MostrarContas();
                double saldoContas = CalcularSaldoContas();
                System.Console.WriteLine($"Saldo das Contas: {saldoContas:c}");
                MostrarPoupancas();
                double saldoPoupancas = CalcularSaldoPoupancas();
                System.Console.WriteLine($"Saldo das Poupancas: {saldoPoupancas:c}");
                double saldoTotal = saldoContas+saldoPoupancas;
                System.Console.WriteLine($"Saldo Total: {saldoTotal:c}");
            }           
        }
    }
}