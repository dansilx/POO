//---------------------- Método Main ---------------------------//

using AbstratoCliente;

//Cliente c = new Cliente(); //não instanciará

ClienteFisico cf = new ClienteFisico(1, "Ana", "Rua Feliz", 18, "12345678910");

ClienteJuridico cj = new ClienteJuridico(100, "Empresa", "Rua Amarela", 40, "987654321000112");

cf.Mostrar();

Teste t = new Teste();
t.VerificaIdade(cf);

cj.Mostrar();

Teste t2 = new Teste();
t2.VerificaIdade(cj);