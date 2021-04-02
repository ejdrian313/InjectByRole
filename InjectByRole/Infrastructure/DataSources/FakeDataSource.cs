using System.Collections.Generic;
using System.Threading.Tasks;

namespace InjectByRole.Repositories
{
    public class FakeDataSource : IDataSource
    {
        readonly List<OrderDto> fakeDataList =
             new List<OrderDto>()
             {
                 new OrderDto
                 {
                     Id = 1,
                     OrderedName = "Name",
                     Price = 3.22m,
                     AdminNote = "secure note",
                     Timestamp = new System.DateTime(2021, 1, 12),
                     ClientId = 222
                 },
                 new OrderDto
                 {
                     Id = 2,
                     OrderedName = "asasfa",
                     Price = 450m,
                     AdminNote = "not shipped",
                     Timestamp = new System.DateTime(2021, 1, 14),
                     ClientId = 333
                 },
                 new OrderDto
                 {
                     Id = 3,
                     OrderedName = "ASfadfas",
                     Price = 6.66m,
                     AdminNote = "securly packed to transport",
                     Timestamp = new System.DateTime(2021, 1, 13),
                     ClientId = 222
                 },
                 new OrderDto
                 {
                     Id = 4,
                     OrderedName = "sag`afasd",
                     Price = 6.22m,
                     AdminNote = "secure f asfawf asfaw",
                     Timestamp = new System.DateTime(2021, 2, 15),
                     ClientId = 333
                 }
             };
        public async Task<IList<OrderDto>> GetOrdersAsync()
        {
            await MockDbDelay();
            return fakeDataList;

        }

        private static async Task MockDbDelay()
        {
            await Task.Delay(1500);
        }
    }
}