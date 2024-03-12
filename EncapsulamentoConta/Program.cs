using EncapsulamentoConta;

Conta c1 = new Conta();
/*c1.SetNumero(1000);
Console.WriteLine($" Número: {c1.GetNumero()}");*/
// usando padrão c#
c1.Numero = 1000; // set
Console.WriteLine($"Número: " + c1.Numero); //get
if (c1.Numero == 1000)
{
    Console.WriteLine("Deu certo!");
}

