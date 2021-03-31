﻿using System.Linq;

namespace SportlandSports.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDBContext context;
        public EFStoreRepository(StoreDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
