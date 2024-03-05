// função Main()
using ClasseProduto;

//intância de objeto produto
Produto produto1 = new Produto();
Console.Write("Digite o código: ");
produto1.codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o nome: ");
produto1.nome = Console.ReadLine();
Console.Write("Digite o preço: ");
produto1.preco = Convert.ToDouble(Console.ReadLine());

produto1.MostrarAtributos();
Console.WriteLine("Informe a porcentagem de aumento: ");
double percentual = Convert.ToDouble(Console.ReadLine());
produto1.CalcularAumento(percentual);
produto1.MostrarAtributos();

