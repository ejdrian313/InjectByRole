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

        [HttpGet("{role}")]
        public async Task<IActionResult> GetAllOrders(UserRole role)
        {
            var query = new GetAllOrdersQuery(role);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
