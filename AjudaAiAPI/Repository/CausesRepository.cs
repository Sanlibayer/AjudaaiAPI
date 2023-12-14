using AjudaAiAPI.Contracts.Repository;
using AjudaAiAPI.Entity;
using AjudaAiAPI.Infrastructure;
using Dapper;

namespace AjudaAiAPI.Repository
{
    public class CausesRepository : Connection, ICausesRepository
    {
        public async Task<IEnumerable<CausesEntity>> Get()
        {
            string sql = "SELECT * FROM CAUSES";
            return await GetConnection().QueryAsync<CausesEntity>(sql);
        }
    }
}
