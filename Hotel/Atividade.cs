public class Atividade{

private static int proximoId = 1;
    public int Id { get; private set; }
    public string Nome { get; set; }

    public  Atividade(){
        Id = proximoId++;
    }
}