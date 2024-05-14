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

        public Funcionario(int codigo, string nome, double salario)
        {   
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
        public virtual void Mostrar() {
            System.Console.WriteLine("Codigo: " + Codigo + "\nNome: " + Nome + "\nSalário: " + Salario);
        }

        public abstract double CalcularSalario(int diasUteis); 
        //assinatura de método, sabemos o que o método faz pelo nome dele, 
        //sabemos se precisa de valor externo pra atender o desenvolvimento 
        //da lógica (parametros) e se ocorrerá saída de valor (return).  
    }
}