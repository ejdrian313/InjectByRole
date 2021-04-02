using System.Collections.Generic;
using System.Threading.Tasks;

namespace InjectByRole.Repositories
{
    public interface IDataSource
    {
        Task<IList<OrderDto>> GetOrdersAsync();
    }
}