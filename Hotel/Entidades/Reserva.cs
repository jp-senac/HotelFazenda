class Reserva {
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public Quarto Quarto {get; set;}
    public Cliente Cliente { get; set; }
}