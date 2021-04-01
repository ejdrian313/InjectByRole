using System;

namespace InjectByRole.Repositories
{
    public class OrderAdmin
    {
        public int Id { get; set; }
        public string OrderedName { get; set; }
        public decimal Price { get; set; }
        public string AdminNote { get; set; }
        public DateTime Timestamp { get; set; }
        public int ClientId { get; set; }
    }

    public class OrderCustomer
    {
        public string OrderedName { get; set; }
        public decimal Price { get; set; }
        public DateTime Timestamp { get; set; }
    }
}