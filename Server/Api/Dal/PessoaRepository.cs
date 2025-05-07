using Api.Domain;

namespace Api.Dal
{
    public class PessoaRepository : IPessoaRepository
    {
        private IPessoaRepository _pessoaRepository;
        public PessoaRepository(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public Task<Pessoa> Create(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Pessoa> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pessoa>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }


    }
}
