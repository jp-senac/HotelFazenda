public class Quarto {
    public int Id { get; set; }
    public string NomeQuarto { get; set; }
    public int QuantidadeMaxima { get; set; }
    public double Diaria { get; set; }

    public double CalcularDiaria(Reserva reserva) {
        if (reserva == null || reserva.Dias <= 0) {
            throw new ArgumentException("Reserva inválida.");
        }
        return reserva.Dias * Diaria;
    }
}






    


