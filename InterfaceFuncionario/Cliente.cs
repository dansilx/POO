using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceFuncionario
{
    public class Cliente : InterfaceAutenticavel
    {
        public int Senha { get; set; }
        public bool Autenticar(int senha) {
            if(Senha == senha) {
                System.Console.WriteLine("Cliente  autenticado!");
                return true;
            }
            return false;
        }
    }
}