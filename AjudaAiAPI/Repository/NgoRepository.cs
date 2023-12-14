using AjudaAiAPI.Contracts.Repository;
using AjudaAiAPI.DTO;
using AjudaAiAPI.Entity;
using AjudaAiAPI.Infrastructure;

namespace AjudaAiAPI.Repository
{
    public class NgoRepository : Connection, INgoRepository
    {
        public Task Add(NgoDTO ngo)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<NgoEntity>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<NgoEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(NgoEntity ngo)
        {
            throw new NotImplementedException();
        }
    }
}
