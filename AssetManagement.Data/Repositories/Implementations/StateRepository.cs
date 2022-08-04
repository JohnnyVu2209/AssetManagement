using AssetManagement.Domain.Model;

namespace AssetManagement.Data.Repositories.Implementations
{
    public class StateRepository :IStateRepository
    {
        private readonly AssetManagementDbContext context;
        public StateRepository(AssetManagementDbContext context) 
        {
            this.context = context;
        }
    }
}