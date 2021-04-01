using Microsoft.AspNetCore.Mvc;
using InjectByRole.Repositories;
using Mapster;
using System.Collections.Generic;

namespace InjectByRole.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private IOrdersRepository _ordersRepository;

        public OrdersController(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var orderDtos = _ordersRepository.GetOrdersAsync();
            var orders = orderDtos.Adapt<List<OrderAdmin>>();
            return Ok(orders);
        }
    }
}
