using System;

namespace InjectByRole.Repositories
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string OrderedName { get; set; }
        public decimal Price { get; set; }
        public string AdminNote { get; set; }
        public DateTime Timestamp { get; set; }
    }
}