// Método Main()
using PolimorfismoFuncionario;

Funcionario f = new Funcionario(1, "Ana", 1000);
System.Console.WriteLine("Bonificação do funcionário: " + f.Bonificacao());

Secretario s = new Secretario(2, "Bel", 1000);
System.Console.WriteLine("Bonificação do Secretário: " + s.Bonificacao());

Gerente g = new Gerente(3, "Bia", 1000);
System.Console.WriteLine("Bonificação do Gerente: " + g.Bonificacao());

Diretor d = new Diretor(4, "Liz", 1000);
System.Console.WriteLine("Bonificação do Diretor: " + d.Bonificacao());