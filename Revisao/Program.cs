/*Console.WriteLine("Olá mundo!!!");
System.Console.Write("Digite se ano de nascimento: ");
int anoNascimento = Convert.ToInt32(Console.ReadLine());
int idade = 2024 - anoNascimento;
Console.WriteLine("Idade: " + idade);
//Estrutura de decisão
if (idade >= 18)
    System.Console.WriteLine("Maior de idade");
else
    System.Console.WriteLine("Menor de idade");

int estacao = 1;
switch (estacao)
{
    case 1: System.Console.WriteLine("Verão");
            break;
    case 2: System.Console.WriteLine("Outono");
            break;
    default: System.Console.WriteLine("Estação inválida");
             break;
}

//Estrutura de repetição - for
for (int t = 1; t <= 10; t++)
    Console.WriteLine("5 x " + t + " = " + (5 * t));

//estrutura de repetição - while
int t = 1;
while (t <= 10)
{
    System.Console.WriteLine("5 x " + t + " = " + (5 * t));
    t++;
}

//estrutura de repetição - do  while
int t = 1;
do
{
    System.Console.WriteLine("5 x " + t + " = " + (5 * t));
    t++;
} while (t <= 10);
//array - vetor
int[] vet = new int[3];
for (int i = 0; i < 3; i++)
{
    System.Console.Write("Digite um número: ");
    vet[i] = Convert.ToInt32(Console.ReadLine());
}
//estrutura de repetição - foreach
foreach (int v in vet)
    System.Console.WriteLine(v);

for(int i = 0; i < vet.Length; i++)
    System.Console.WriteLine(vet[i]);

//função sem parâmetro e sem retorno
void Somar()
{
    int a = 10;
    int b = 2;
    int r = a + b;
    System.Console.WriteLine("O resultado é " + r);
}
//chamar a função
Somar();

//função com parâmetro e sem retorno
void Somar(int a, int b)
{
    System.Console.WriteLine("O resultado é " + (a + b));
}
int x = 22;
int y = 51;
Somar(x,y);

//função sem parâmetro e com retorno
int Somar()
{
    int a = 41;
    int b = 10;
    return a + b;
}
Console.WriteLine("O resultado é " + Somar());
//ou
int result = Somar();
Console.WriteLine("O resultado é " + result);
//if (result > 0)
*/
//função com parâmetro e com retorno
int Somar(int a, int b)
{
    return a + b;
}
Console.WriteLine("O resultado é " + Somar(10, 25));
//ou 
//int r = Somar(10, 25)

