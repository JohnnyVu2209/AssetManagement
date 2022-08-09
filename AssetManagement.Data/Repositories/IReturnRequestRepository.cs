using AssetManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Data.Repositories
{
    public interface IReturnRequestRepository
    {
        Task<IEnumerable<ReturnRequest>> GetAsync(string? searching,DateTime? returnDate,List<int>? state);
    }
}
