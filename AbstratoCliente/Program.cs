//---------------------- Método Main ---------------------------//

using AbstratoCliente;

//Cliente c = new Cliente(); //não instanciará

ClienteFisico cf = new ClienteFisico(1, "Ana", "Rua Feliz", "12345678910");

ClienteJuridico cj = new ClienteJuridico(100, "Empresa", "Rua Amarela", "987654321000112");

cf.Mostrar();
cj.Mostrar();