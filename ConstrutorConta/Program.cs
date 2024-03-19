// Função Main()
using ConstrutorConta;

Conta c1 = new Conta();

c1.MostrarAtributos();

Conta c2 = new Conta(235);

c2.MostrarAtributos();

Conta c3 = new Conta(122, 2055.99);

c3.MostrarAtributos();

Conta c4 = new Conta(2, 100, "Ana");
c4.MostrarAtributos();

int contador = 0;

Console.WriteLine("Quantidade de instâncias " + Conta.Contador);