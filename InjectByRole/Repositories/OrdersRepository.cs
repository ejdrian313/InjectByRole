using System.Collections.Generic;

namespace InjectByRole.Repositories
{
    public interface IOrdersRepository
    {
        List<OrderDto> GetOrdersAsync();
    }

    public class OrdersRepository : IOrdersRepository
    {
        public List<OrderDto> GetOrdersAsync()
        {
            return new List<OrderDto> { };
        }
    }
}