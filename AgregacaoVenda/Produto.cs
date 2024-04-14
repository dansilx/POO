using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        private static int codigoInicial;
        public static int CodigoInicial {
            get {return codigoInicial;}
            private set {codigoInicial = value;}
        }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        private double Preco { get; set; };
        
        static Produto() {
            CodigoInicial = 500;
        }

        public Produto(string nome, double preco) {
            codigoInicial++;
            this.Codigo = codigoInicial;
            this.Nome = nome;
            this.Preco = preco;
        }

        public void MostrarAtributos() {
            System.Console.WriteLine($"Produto: {Nome}\n Código: {Codigo}\n Preço: {Preco:c}");
        }
    }
}