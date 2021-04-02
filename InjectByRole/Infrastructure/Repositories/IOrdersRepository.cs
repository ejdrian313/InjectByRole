using System.Collections.Generic;
using System.Threading.Tasks;
using InjectByRole.Entities;

namespace InjectByRole.Repositories
{
    public interface IOrdersRepository
    {
        Task<IList<OrderAdmin>> GetOrdersAsync(int userId);
        bool UserIsInRole(UserRole userRole);
    }
}