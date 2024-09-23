System.Console.WriteLine("Bem vindo ao hotel, digite seu nome");

string nome = Console.ReadLine();
Cliente usuario = new Cliente();
usuario.NomeUsuario = nome;
System.Console.WriteLine($"Olá {usuario.NomeUsuario} faça sua reserva");
usuario.CadastrarReserva();




