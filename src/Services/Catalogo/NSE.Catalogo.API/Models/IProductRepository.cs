﻿using NSE.Core.Interfaces;

namespace NSE.Catalog.API.Models
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetAsync(Guid id);
        void Add(Product product);
        void Update (Product product);

    }
}
