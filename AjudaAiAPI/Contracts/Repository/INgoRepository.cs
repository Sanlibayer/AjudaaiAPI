using AjudaAiAPI.DTO;
using AjudaAiAPI.Entity;

namespace AjudaAiAPI.Contracts.Repository
{
    public interface INgoRepository 
    {
        Task Add(NgoDTO ngo);
        Task Update(NgoEntity ngo);
        Task Delete(int id);
        Task<NgoEntity> GetById(int id);
        Task<IEnumerable<NgoEntity>> Get();
        Task<TokenDTO> LogIn(LoginDTO ngo);
    }
}
