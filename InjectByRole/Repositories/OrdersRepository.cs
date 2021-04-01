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
            return new List<OrderDto> {
                new OrderDto {
                    Id = 1,
                    OrderedName = "Name",
                    Price = 3.22m,
                    AdminNote = "secure note",
                    Timestamp = new System.DateTime(2021, 1, 12)
                }
            };
        }
    }
}