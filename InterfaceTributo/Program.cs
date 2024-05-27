using InterfaceTributo;

SeguroDeVida seguro = new SeguroDeVida();
ContaCorrente conta = new ContaCorrente();
consta.Saldo = 1000;

TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
totalizador.Adiciona(seguro);
totalizador.Adiciona(conta);

System.Console.WriteLine("Tributos Totais: " + totalizador.Total);