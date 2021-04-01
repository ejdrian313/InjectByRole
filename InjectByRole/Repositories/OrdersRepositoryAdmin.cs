using System.Collections.Generic;
using System.Threading.Tasks;
using InjectByRole.Entities;

namespace InjectByRole.Repositories
{
    public class OrdersRepositoryAdmin : IOrdersRepository
    {
        private readonly IDataSource dataSource;

        public OrdersRepositoryAdmin(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public async Task<IList<OrderDto>> GetOrdersAsync()
        {
            return await dataSource.GetOrdersAsync();
        }

        public bool UserIsInRole(UserRole userRole)
        {
            return userRole is UserRole.Admin;
        }
    }
}