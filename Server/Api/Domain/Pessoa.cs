namespace Api.Domain
{
    public class Pessoa
    {
        public int Id { get; set; }
        public required string Nome { get; set; }

        public required DateTime DataNascimento { get; set; }

        public required string Endereco { get; set; }

 
    }
}
