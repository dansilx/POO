using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Funcionario
    {
        protected int codigo;
        protected string nome;
        protected double salario;

        public Funcionario(){}
        
        public Funcionario(int codigo, string nome, double salario){
            Codigo = codigo;
            nome = nome;
            salario = salario;
        }

        public void Mostrar() {
            System.Console.WriteLine("Código: " + codigo + "\nNome: " + nome + "\nSalario: " + salario);
        }
        
        public int Codigo {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome {
            get { return nome; }
            set { nome = value; }
        }

        public double Salario {
            get { return salario; }
            set { salario = value; }
        }
    }
}