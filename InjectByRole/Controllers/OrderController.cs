using Microsoft.AspNetCore.Mvc;
using InjectByRole.Repositories;

namespace InjectByRole.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private IOrdersRepository _ordersRepository;

        public OrderController(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            _ordersRepository.GetOrdersAsync();

            return Ok();
        }
    }
}
