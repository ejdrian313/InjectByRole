using System.Collections.Generic;
using System.Threading.Tasks;
using InjectByRole.Entities;

namespace InjectByRole.Repositories
{
    public interface IOrdersRepository
    {
        Task<IList<OrderDto>> GetOrdersAsync();
        bool UserIsInRole(UserRole userRole);
    }
}