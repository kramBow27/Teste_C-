namespace Api.Domain
{
    public interface IPessoaRepository
    {
        Task<IEnumerable<Pessoa>> GetAll();
        Task<Pessoa> Get(int id);
        Task<Pessoa> Create(Pessoa pessoa);
        Task Update(Pessoa pessoa);
        Task Delete (int id);
    }
}
