using System.Collections.Generic;
using InjectByRole.Entities;
using LanguageExt;
using MediatR;

namespace InjectByRole.Controllers
{
    public class GetAllOrdersQuery : IRequest<Option<List<OrderAdmin>>>
    {
        public UserRole userRole;
        public int userId;

        public GetAllOrdersQuery(UserRole userRole, int userId)
        {
            this.userRole = userRole;
            this.userId = userId;
        }
    }
}