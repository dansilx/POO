using ComposicaoNotaFiscal;

ItemNotaFiscal item1 = new ItemNotaFiscal(10);
ItemNotaFiscal item2 = new ItemNotaFiscal(5);

NotaFiscal nf = new NotaFiscal(1, "01/04/2024");
nf.AdicionaItens(item1);
nf.AdicionaItens(item2);

foreach(ItemNotaFiscal itens in nf.VetItems)
    Console.WriteLine("\nQuantidade: " + itens.Quantidade);
    