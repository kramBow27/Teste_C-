namespace Api.Domain
{
    public class PessoaDTO
    {
        public required string Nome { get; set; }

        public required DateTime DataNascimento { get; set; }

        public required string Endereco { get; set; }
    }
}
