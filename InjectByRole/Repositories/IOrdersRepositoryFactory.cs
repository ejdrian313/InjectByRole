﻿using System.Collections.Generic;
using System.Linq;
using InjectByRole.Entities;

namespace InjectByRole.Repositories
{

    public interface IOrdersRepositoryFactory
    {
        IOrdersRepository ProvideOrdersRepository(UserRole userRole);
    }

    public class OrdersRepositoryFactory : IOrdersRepositoryFactory
    {
        private readonly IEnumerable<IOrdersRepository> repositories;

        public OrdersRepositoryFactory(IEnumerable<IOrdersRepository> repositories)
        {
            this.repositories = repositories;
        }

        public IOrdersRepository ProvideOrdersRepository(UserRole userRole)
        {
            var repository = repositories.First(r => r.UserIsInRole(userRole));
            return repository;
        }
    }
}