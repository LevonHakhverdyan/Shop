using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services
{
    public interface IProductservice
    {
        void Add(Product item);
        Product Get(Guid id);
        void Update(Product item);
        bool Remove(Product item);
        List<Product> GetAll();
    }
}
