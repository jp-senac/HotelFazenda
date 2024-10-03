public class Cliente : Usuario
    {
                public void CadastrarReserva() { 
                    System.Console.WriteLine("Selecione o quarto");
                    string nomeQuarto = Console.ReadLine();
                    Quarto quarto = new Quarto();
                    quarto.Nome = nomeQuarto;
                    System.Console.WriteLine("Perfeito, reserva concluida com sucesso.");
                    System.Console.WriteLine("Adicionar atividade?");
                 string atividade = Console.ReadLine();
                 Atividade activity = new Atividade();
                 activity.Nome = atividade;
                 System.Console.WriteLine($"Feito {activity.Nome} adiconada");

                }
    }