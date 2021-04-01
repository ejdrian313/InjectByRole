using System.Collections.Generic;

namespace InjectByRole.Repositories
{
    public interface IOrdersRepository
    {
        ICollection<OrderDto> GetOrdersAsync();
    }

    public class OrdersRepository : IOrdersRepository
    {
        public ICollection<OrderDto> GetOrdersAsync()
        {
            return new List<OrderDto> {
                new OrderDto {
                    Id = 1,
                    OrderedName = "Name",
                    Price = 3.22m,
                    AdminNote = "secure note",
                    Timestamp = new System.DateTime(2021, 1, 12),
                    ClientId = 222
                },
                new OrderDto {
                    Id = 2,
                    OrderedName = "asasfa",
                    Price = 450m,
                    AdminNote = "not shipped",
                    Timestamp = new System.DateTime(2021, 1, 14),
                    ClientId = 333
                },
                new OrderDto {
                    Id = 3,
                    OrderedName = "ASfadfas",
                    Price = 6.66m,
                    AdminNote = "securly packed to transport",
                    Timestamp = new System.DateTime(2021, 1, 13),
                    ClientId = 222
                },
                new OrderDto {
                    Id = 4,
                    OrderedName = "sag`afasd",
                    Price = 6.22m,
                    AdminNote = "secure f asfawf asfaw",
                    Timestamp = new System.DateTime(2021, 2, 15),
                    ClientId = 333
                }
            };
        }
    }
}