using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using InjectByRole.Controllers;
using InjectByRole.Entities;
using InjectByRole.Repositories;
using LanguageExt;
using LanguageExt.SomeHelp;
using MediatR;

namespace InjectByRole.Handlers
{

    public class GetAllOrdersHandler : IRequestHandler<GetAllOrdersQuery, Option<List<OrderAdmin>>>
    {
        private readonly IOrdersRepositoryFactory _ordersRepositoryFactory;

        public GetAllOrdersHandler(IOrdersRepositoryFactory ordersRepositoryFactory)
        {
            _ordersRepositoryFactory = ordersRepositoryFactory;
        }

        public async Task<Option<List<OrderAdmin>>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            var repository = _ordersRepositoryFactory.ProvideOrdersRepository(request.userRole);
            var orders = await repository.GetOrdersAsync(request.userId);
            if (orders.IsNullOrEmpty())
                return Option<List<OrderAdmin>>.None;

            return orders.ToList().ToSome();
        }
    }
}
