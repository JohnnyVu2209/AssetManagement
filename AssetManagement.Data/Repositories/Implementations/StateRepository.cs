using AssetManagement.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data.Repositories.Implementations
{
    public class StateRepository :IStateRepository
    {
        private readonly AssetManagementDbContext context;
        public StateRepository(AssetManagementDbContext context) 
        {
            this.context = context;
        }

        public Task<List<State>> GetAllAsync()
        {
            return context.States.ToListAsync();
        }

        public Task<State?> GetByIdAsync(int id)
        {
            return context.States.FindAsync(id).AsTask();
        }
    }
}