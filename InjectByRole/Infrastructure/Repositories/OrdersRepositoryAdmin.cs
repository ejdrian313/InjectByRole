using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InjectByRole.Entities;
using Mapster;

namespace InjectByRole.Repositories
{
    public class OrdersRepositoryAdmin : IOrdersRepository
    {
        private readonly IDataSource dataSource;

        public OrdersRepositoryAdmin(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public async Task<IList<OrderAdmin>> GetOrdersAsync(int clientId)
        {
            var orderDtos = await dataSource.GetOrdersAsync();
            var mapped = orderDtos.ToList()
                .Adapt<List<OrderAdmin>>();
            return mapped;
        }

        public bool UserIsInRole(UserRole userRole)
        {
            return userRole is UserRole.Admin;
        }
    }
}