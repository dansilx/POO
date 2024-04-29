using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {   
        private string dataFabricacao;
        private string dataValidade;
        private int lote;

        public string dataFabricacao {
            get{return dataFabricacao;}
            set{dataFabricacao = value;}
        } 

        public string DataValidade {
            get{return dataValidade;}
            set{dataValidade = value;}
        }

        public int Lote {
            get{return lote;}
            set{lote = value;}
        }
    }
}