using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public virtual void Mostrar() {
            System.Console.WriteLine("Codigo: " + Codigo + "\nNome: " + Nome + "\nSalário: " + Salario);
        }

        public abstract double CalcularSalario();
    }
}