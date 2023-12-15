using AjudaAiAPI.Contracts.Repository;
using AjudaAiAPI.DTO;
using AjudaAiAPI.Entity;
using AjudaAiAPI.Infrastructure;
using Dapper;

namespace AjudaAiAPI.Repository
{
    public class NgoRepository : Connection, INgoRepository
    {
        public async Task Add(NgoDTO ngo)
        {
            string sql = @"
                INSERT INTO NGO (Name, Social, HeadPerson, Telephone, Email, Password, CityId, CausesId)
                        VALUE (@Name, @Social, @HeadPerson, @Telephone, @Email, @Password, @CityId, @CausesId)
            ";
            await Execute(sql, ngo);
        }

        public async Task Delete(int id)
        {
            string sql = "DELETE FROM NGO WHERE Id = @id";
            await Execute(sql, new { id });
        }

        public async Task<IEnumerable<NgoEntity>> Get()
        {
            string sql = "SELECT * FROM NGO";
            return await GetConnection().QueryAsync<NgoEntity>(sql);
        }

        public async Task<NgoEntity> GetById(int id)
        {
            string sql = "SELECT * FROM NGO WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<NgoEntity>(sql, new { id });
        }

        public async Task Update(NgoEntity ngo)
        {
            string sql = @"
                UPDATE ONG 
                    SET 
                        Name = @Name,
                        Social = @Social, 
                        HeadPerson = @HeadPerson, 
                        Telephone = @Telephone, 
                        Email = @Email, 
                        Password = @Password, 
                        CityId = @CityId, 
                        CausesId = @CausesId
                WHERE Id = @Id
            ";
            await Execute(sql, ngo);
        }
    }
}
