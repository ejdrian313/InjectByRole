using System;

namespace InjectByRole.Entities
{
    public class Order
    {
        public string OrderedName { get; set; }
        public decimal Price { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class OrderAdmin : Order
    {
        public int Id { get; set; }
        public string AdminNote { get; set; }
        public int ClientId { get; set; }
    }

    public class OrderCustomer : Order
    {
    }
}