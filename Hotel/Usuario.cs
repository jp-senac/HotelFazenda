
    public abstract class Usuario
    {
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Status { get; set; }

        public void Cadastrar() { }
        public void Atualizar() { }
        public void Logar() { }
    }