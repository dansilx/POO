using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Cliente
    {
        public string? Nome { get; set; }
        public string? Rg { get; set; }
        public string? Cpf { get; set; }
        public Endereco Ender { get; set; }
        public Cliente(string? nome, string? rg, string? cpf)
        {
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
        }    
    }
}