using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.Utilities
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Paged<T>(this IQueryable<T> source, int page, int limit)
        {
            return source.Skip((page - 1) * limit).Take(limit);
        }
    }
}
