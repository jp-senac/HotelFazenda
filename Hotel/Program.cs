List<Quarto> quartos = new List<Quarto>
{
new Quarto { Id = 1, NomeQuarto = "Quarto Simples", QuantidadeMaxima = 2, Diaria = 100 },
new Quarto { Id = 2, NomeQuarto = "Quarto Duplo", QuantidadeMaxima = 4, Diaria = 200 },
new Quarto { Id = 3, NomeQuarto = "Quarto Luxo", QuantidadeMaxima = 2, Diaria = 300 }
};

Console.WriteLine("Bem-vindo ao hotel, digite seu nome:");
string nome = Console.ReadLine();

Cliente usuario = new Cliente { NomeUsuario = nome };
Console.WriteLine($"Olá {usuario.NomeUsuario}, faça sua reserva.");
usuario.CadastrarReserva(quartos);
