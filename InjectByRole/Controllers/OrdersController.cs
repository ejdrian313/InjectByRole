using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using InjectByRole.Entities;

namespace InjectByRole.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders(UserRole role, int clientId)
        {
            var query = new GetAllOrdersQuery(role, clientId);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
