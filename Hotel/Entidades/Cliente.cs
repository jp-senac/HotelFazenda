public class Cliente : Usuario
{
    public double Conta { get; set; }

    public void CadastrarReserva(List<Quarto> quartos)
    {
        Console.WriteLine("Selecione o quarto:");
        for (int i = 0; i < quartos.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {quartos[i].NomeQuarto} - R${quartos[i].Diaria} por dia");
        }

        int escolha = Convert.ToInt32(Console.ReadLine()) - 1;
        if (escolha < 0 || escolha >= quartos.Count)
        {
            Console.WriteLine("Quarto inválido.");
            return;
        }

        Quarto quartoEscolhido = quartos[escolha];

        Console.WriteLine("Quantos dias?");
        int dias = Convert.ToInt32(Console.ReadLine());

        Reserva reserva = new Reserva
        {
            Quarto = quartoEscolhido,
            Dias = dias,
            Data = DateTime.Now,
            Cliente = this
        };

        double total = quartoEscolhido.CalcularDiaria(reserva);
        Console.WriteLine($"Reserva concluída com sucesso para o quarto {quartoEscolhido.NomeQuarto} por {dias} dias. Total: R${total}");
    }
}