using ArrayProduto;

Produto[] vetP = new Produto[3];
for(int i = 0; i < vetP.Length; i++)
{
    //instanciar cada possição do vetor
    vetP[i] = new Produto();
    Console.Write("Digite o código: ");
    vetP[i].codigo= Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o nome: ");
    vetP[i].nome= Console.ReadLine();
    Console.Write("Digite o preço: ");
    vetP[i].preco= Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite a quantidade: ");
    vetP[i].quantidade = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < vetP.Length; i++)
    vetP[i].MostrarAtributos();

foreach (Produto p in vetP)
    p.MostrarAtributos();

Console.WriteLine("Informe a porcentagem de aumento: ");

double percentual = Convert.ToDouble(Console.ReadLine());

for(int i = 0; i < vetP.Length; i++)
{
    vetP[i].CalcularAumento(percentual);   
    vetP[i].MostrarAtributos();
    Console.WriteLine($"Valor total do produto {vetP[i].nome}:   {vetP[i].ValorTotalEstoque()}");
}

