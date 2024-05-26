using InterfaceFuncionario;

Cliente c = new Cliente();
c.Senha = 100;

InterfaceAutenticavel itc = c;
System.Console.WriteLine("Autenticou? " + itc.Autenticar(100));

Diretor d = new Diretor();
d.Senha = 200;

InterfaceAutenticavel itd = d;
System.Console.WriteLine("Autenticou? " + itd.Autenticar(201));

Gerente g= new Gerente();
g.Senha = 300;

InterfaceAutenticavel itg = g;
System.Console.WriteLine("Autenticou? " + itg.Autenticar(300));