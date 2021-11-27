﻿using Shop.Base;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public Product Get(Guid id)
        {
            return items.FirstOrDefault(x => x.Id == id);
        }

        public static implicit operator ProductRepository(List<Product> v)
        {
            throw new NotImplementedException();
        }
    }
}
