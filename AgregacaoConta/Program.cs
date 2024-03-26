//Função Main

using AgregacaoConta;

Endereco end = new Endereco("Rua Fatec", 75, "PP");

Cliente cli = new Cliente("Ana", "1111", "1111-11");
cli.Ender = end; //agregando o endereço no cliente 

Conta c1 = new Conta();
c1.Numero = 1;
c1.Titular = cli;
c1.Saldo = 100;

Console.WriteLine("Número da Conta: " + c1.Numero);
Console.WriteLine("Nome: " + c1.Titular.Nome);
Console.WriteLine("RG: " + c1.Titular.Rg);
Console.WriteLine("CPF: " + c1.Titular.Cpf);
Console.WriteLine("Saldo: " + c1.Saldo);
Console.WriteLine("Endereço: " + c1.Titular.Ender.Logradouro);
Console.WriteLine("Número: " + c1.Titular.Ender.Numero);
Console.WriteLine("Cidade: " + c1.Titular.Ender.Cidade);