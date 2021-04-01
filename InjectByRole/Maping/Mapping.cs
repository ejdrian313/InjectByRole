using System.Collections.Generic;
using InjectByRole.Repositories;
using Mapster;

namespace InjectByRole.Maping
{
    public class Mapping : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<OrderDto, OrderAdmin>();
            config.NewConfig<OrderDto, OrderCustomer>();
            config.NewConfig<List<OrderDto>, List<OrderAdmin>>();
            config.NewConfig<List<OrderDto>, List<OrderCustomer>>();
        }
    }
}
