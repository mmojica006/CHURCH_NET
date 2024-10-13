using CHURCH.Application.Interface;
using CHURCH.Domain.Entities;
using CHURCH.Persistence.Context;
using Dapper;
using System.Data;

namespace CHURCH.Persistence.Repository
{
    public class DistritosRepository : IDistritoRepository
    {
        private readonly ApplicationDbContext _context;
        public DistritosRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Distritos>> ListDistritos()
        {
            using var connection = _context.CreateConnection;
            var query = "uspDistritosList";
            var distritos = await connection.QueryAsync<Distritos>(query, commandType:CommandType.StoredProcedure);
            return distritos;
            
        }
    }
}
