using System.Collections.Generic;
using System.Threading.Tasks;

using Enrollment.api.Model.Data;

namespace Enrollment.api.Repositories
{
    public interface IOrderRepository
    {
         Task<List<DepOrder>>  GetDepOrders();
    }
}