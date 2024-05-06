using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Mensalista : Funcionario
    {
        private int qtdeHrsTrab;

        public int QtdeHrsTrab {
            get { return qtdeHrsTrab; }
            set { qtdeHrsTrab = value; }
        }

        public Mensalista() : base() {

        }
        public Mensalista (int codigo, string nome, double salario, int qtdeHrsTrab) : base ( codigo,  nome, salario) {
            QtdeHrsTrab = qtdeHrsTrab;
        }

        public override void Mostrar() {
            base.Mostrar();
            System.Console.WriteLine("\nQuantidade de horas trabalhadas: " + QtdeHrsTrab);
        }
    }
}