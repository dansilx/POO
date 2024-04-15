using ComposicaoBanco;

Banco banco = new Banco();
banco.IniciarBanco();

banco.AbrirConta(2000,2000);
banco.AbrirConta(0,2000);
banco.AbrirConta(0,0);

banco.AbrirPoupanca(2000);
banco.AbrirPoupanca(0);
banco.AbrirPoupanca(1000);

banco.MostrarAtributos();

foreach (Poupanca poupanca in banco.Poupancas){
    poupanca.GerarRendimento();
}

banco.MostrarAtributos();

Random rand = new Random();

for(int i = 0; i < banco.Contas.Count; i++)
{
    int deposito = rand.Next(0,2000);
    
    System.Console.WriteLine($"Depositando {deposito:c}");
    banco.Contas[i].Depositar(deposito);
    banco.Contas[i].GerarExtrato();
    
}

banco.MostrarAtributos();

for(int i = 0; i < banco.Contas.Count; i++)
{
    int saque = rand.Next(0,2000);
    
    System.Console.WriteLine($"Sacando {saque:c}");
    if(banco.Contas[i].Sacar(saque))
        System.Console.WriteLine("Transação Realizada");
    else
        System.Console.WriteLine("Saldo/Limite indisponível");
    banco.Contas[i].GerarExtrato();
    
}

banco.MostrarAtributos();

for(int i = 0; i < banco.Poupancas.Count; i++)
{
    int deposito = rand.Next(0,1000);
    
    System.Console.WriteLine($"Depositando {deposito:c}");
    banco.Poupancas[i].Depositar(deposito);
    banco.Poupancas[i].MostrarAtributos();
}

banco.MostrarAtributos();

banco.DecretarFalencia();

banco.MostrarAtributos();