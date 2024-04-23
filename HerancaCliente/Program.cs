using HerancaCliente;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Fatec";
c.Endereco = "Rua Terezina, 75";
c.Mostrar();


ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Ana";
cf.Endereco = "Rua Centro, 2";
cf.Rg = "2";
cf.Mostrar();

ClienteFisico cf2 = new ClienteFisico(4, "Lia", "Rua Centro, 4", "4");
cf2.Mostrar();

ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 3;
cj.Nome = "Bia";
cj.Endereco = "Rua Centro, 3";
cj.Cnpj = "3";
cj.Mostrar();