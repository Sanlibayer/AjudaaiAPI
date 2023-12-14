using AjudaAiAPI.Contracts.Repository;
using AjudaAiAPI.Entity;
using AjudaAiAPI.Infrastructure;
using Dapper;

namespace AjudaAiAPI.Repository
{
    public class StateRepository : Connection, IStateRepository
    {
        public async Task<IEnumerable<StateEntity>> Get()
        {
            string sql = "SELECT * FROM STATE";
            return await GetConnection().QueryAsync<StateEntity>(sql);
        }
    }
}
