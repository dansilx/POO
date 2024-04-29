//Método Main()
using HerancaProduto;

Produto p = new Produto();
Produto p1 = new Produto(1, "mouse", 50);
p1.Mostrar();

Perecivel pe = new Perecivel();
Perecivel pe2 = new Perecivel(2, "lanche", 21, "28/04/2024", "29/04/2024", 123123 );
pe2.Mostrar();