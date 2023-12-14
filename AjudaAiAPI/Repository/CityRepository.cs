using AjudaAiAPI.Contracts.Repository;
using AjudaAiAPI.Entity;
using AjudaAiAPI.Infrastructure;
using Dapper;

namespace AjudaAiAPI.Repository
{
    public class CityRepository : Connection, ICityRepository
    {

        public async Task<IEnumerable<CityEntity>> Get()
        {
            string sql = "SELECT * FROM CITY";
            return await GetConnection().QueryAsync<CityEntity>(sql);
        }

        public async Task<IEnumerable<CityEntity>> GetByState(int id)
        {
            string sql = @"SELECT
                           C.*
                           FROM CITY C
                           JOIN STATE S
                           ON C.StateId = S.Id
                           WHERE C.StateId = @Id"; ;
            return await GetConnection().QueryAsync<CityEntity>(sql, new { id });
        }
    }
}
