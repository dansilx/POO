using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Horista : Funcionario
    {
        private int qtdeHrsSem;

        public int QtdeHrsSem{
            get { return qtdeHrsSem; }
            set { qtdeHrsSem = value; }
        }

        public Horista() : base() {
            
        }
        public Horista (int codigo, string nome, double salario, int qtdeHrsSem) : base ( codigo,  nome, salario) {
            QtdeHrsSem = qtdeHrsSem;
        }

        public override void Mostrar() {
            base.Mostrar();
            System.Console.WriteLine("\nQuantidade de horas semanais: " + QtdeHrsSem);
        }
    }
}