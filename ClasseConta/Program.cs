// função Main()

using ClasseConta;

Conta objetoConta; //declarar variável
objetoConta = new Conta();//instância de objeto
objetoConta.numero = 1;
objetoConta.titular = "Paul";
objetoConta.saldo = 100.57;
objetoConta.MostrarAtributos();
objetoConta.Sacar(10);
objetoConta.MostrarAtributos();

//outra forma de instanciação - mais usada
Conta objetoConta2 = new Conta();
Console.Write("Digite o número: ");
objetoConta2.numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o titular: ");
objetoConta2.titular = Console.ReadLine();
Console.Write("Digite o saldo: ");
objetoConta2.saldo = Convert.ToDouble(Console.ReadLine());
objetoConta2.MostrarAtributos();
objetoConta2.Depositar(100);
objetoConta2.MostrarAtributos();