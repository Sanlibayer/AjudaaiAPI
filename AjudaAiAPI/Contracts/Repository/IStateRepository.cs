using AjudaAiAPI.Entity;

namespace AjudaAiAPI.Contracts.Repository
{
    public interface IStateRepository
    {
        Task<IEnumerable<StateEntity>> Get();
    }
}
