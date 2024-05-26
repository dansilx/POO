using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceFuncionario
{
    public class Diretor : Funcionario, InterfaceAutenticavel
    {
        public bool Autenticar(int senha) {
            if(Senha == senha) {
                System.Console.WriteLine("Diretor autenticado");
                return true;
            }
            return false;
        }
    }
}