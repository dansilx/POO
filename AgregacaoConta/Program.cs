//Função Main

using AgragacaoConta;

Endereco end = new Endereco("Rua Fatec", 75, "PP");

Cliente cli = new Cliente("Ana", "1111", "1111-11");
cli.Ender = end; //agregando o endereço no cliente 

Conta c1 = new Conta();
c1.Numero = 1;
c1.Titular = cli;
c1.Saldo = 100;

Console.WriteLine(c1.Titular.Logradouro);