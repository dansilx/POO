using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayFuncionario
{
    public class Funcionario
    {
        //declaração dos atributos
        public int codigo;
        public string nome;
        public double salario;
        //declaração dos métodos
        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {codigo} \tNome: {nome} \tSalário: {salario:c}");
        }
    }
}