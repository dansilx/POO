using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceFuncionario
{
    public class Gerente : Funcionario, InterfaceAutenticavel
    {
        public bool Autenticar(int senha) {
            if(Senha == senha) {
                System.Console.WriteLine("Gerente autenticado!");
                return true;
            }
            return false;
        }
    }
}