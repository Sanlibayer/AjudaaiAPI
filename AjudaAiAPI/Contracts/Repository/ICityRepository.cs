using AjudaAiAPI.Entity;

namespace AjudaAiAPI.Contracts.Repository
{
    public interface ICityRepository
    {
        Task<IEnumerable<CityEntity>> Get();
        Task<IEnumerable<CityEntity>> GetByState(int id);
    }
}
