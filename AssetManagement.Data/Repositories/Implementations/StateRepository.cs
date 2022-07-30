using AssetManagement.Domain.Model;

namespace AssetManagement.Data.Repositories.Implementations
{
    public class StateRepository : GenericRepository<State>, IStateRepository
    {
        public StateRepository(AssetManagementDbContext context) : base(context) { }
    }
}