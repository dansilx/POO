using HerancaCliente;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Fatec";
c.Endereco = "Rua Terezina, 75";


ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Ana";
cf.Endereco = "Rua Centro, 2";
cf.Rg = "2";
cf.Mostrar();

ClienteJuridico cj = new ClienteJuridico();
//cj.Mostrar();