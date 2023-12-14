using AjudaAiAPI.Entity;

namespace AjudaAiAPI.Contracts.Repository
{
    public interface ICausesRepository
    {
        Task<IEnumerable<CausesEntity>> Get();
    }
}
