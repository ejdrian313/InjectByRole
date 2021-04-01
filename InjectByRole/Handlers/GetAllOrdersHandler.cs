using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using InjectByRole.Controllers;
using InjectByRole.Repositories;
using MediatR;

namespace InjectByRole.Handlers
{
    public class GetAllOrdersHandler : IRequestHandler<GetAllOrdersQuery, List<OrderDto>>
    {
        private readonly IOrdersRepositoryFactory _ordersRepositoryFactory;

        public GetAllOrdersHandler(IOrdersRepositoryFactory ordersRepositoryFactory)
        {
            _ordersRepositoryFactory = ordersRepositoryFactory;
        }

        public async Task<List<OrderDto>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            var repository = _ordersRepositoryFactory.ProvideOrdersRepository(request.userRole);
            var orders = await repository.GetOrdersAsync();
            return orders.ToList();
        }
    }
}
