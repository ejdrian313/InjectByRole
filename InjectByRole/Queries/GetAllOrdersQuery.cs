using System.Collections.Generic;
using InjectByRole.Entities;
using InjectByRole.Repositories;
using MediatR;

namespace InjectByRole.Controllers
{
    public class GetAllOrdersQuery : IRequest<List<OrderDto>>
    {
        public UserRole userRole;

        public GetAllOrdersQuery(UserRole userRole)
        {
            this.userRole = userRole;
        }
    }
}