using AgregacaoVenda;

Vendedor vendedor = new Vendedor();
vendedor.MostrarAtributos();
Comprador comprador = new Comprador();
comprador.MostrarAtributos();

Produto p1 = new Produto("");
p1.MostrarAtributos();
Produto p2 = new Produto("");
p2.MostrarAtributos();
Produto p3 = new Produto("");
p3.Mostrartributos();
Produto p4 = new Produto("");
p4.MostrarAtributos();
Produto p5 = new Produto("");
p5.MostrarAtributos();

Venda venda = new Venda();
venda.Comp = comprador;
venda.Vend = vendedor;

venda.VetProd.Add(p1);
venda.VetProd.Add(p2);
venda.VetProd.Add(p3);
venda.VetProd.Add(p4);
venda.VetProd.Add(p5);

venda.calcularComissao();
venda.registrarCompra();
venda.MostrarAtributos();