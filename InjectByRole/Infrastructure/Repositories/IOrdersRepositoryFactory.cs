using InjectByRole.Entities;

namespace InjectByRole.Repositories
{
    public interface IOrdersRepositoryFactory
    {
        IOrdersRepository ProvideOrdersRepository(UserRole userRole);
    }
}