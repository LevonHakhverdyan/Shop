using Shop.Models;
using Shop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services
{
    public class Productservice : IProductservice
    {
        private readonly IProductRepository _productRepository;
        public Productservice(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Add(Product item)
        {
            _productRepository.Add(item);
        }
        public bool Remove(Product item)
        {
            return _productRepository.Remove(item);
        }

        public Product Get(Guid id)
        {
            return _productRepository.Get(id);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
        public void Update(Product item)
        {
            Product oltProduct = _productRepository.Get(item.Id);
            int index = _productRepository.IndexOf(oltProduct);
            _productRepository.Update(item, index);
        }
    }
}
