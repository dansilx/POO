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
    }
}