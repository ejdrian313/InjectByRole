using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InjectByRole.Entities;
using Mapster;

namespace InjectByRole.Repositories
{
    public class OrdersRepositoryCustomer : IOrdersRepository
    {
        private readonly IDataSource dataSource;

        public OrdersRepositoryCustomer(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public async Task<IList<OrderDto>> GetOrdersAsync()
        {
            var orderDtos = await dataSource.GetOrdersAsync();
            var filtered = orderDtos.ToList()
                .Where(o => o.ClientId == 222)
                .ToList()
                .Adapt<List<OrderCustomer>>()
                .Adapt<List<OrderDto>>();
            return filtered;
        }

        public bool UserIsInRole(UserRole userRole)
        {
            return userRole is UserRole.Customer;
        }
    }
}