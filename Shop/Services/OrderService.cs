using Shop.Models;
using Shop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services
{
    public class OrderService : IOrderService

    {
        private readonly OrderRepository _orderRepository;
        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public void Add(Order item)
        {
            _orderRepository.Add(item);
        }

        public Order Get(Guid id)
        {
            return _orderRepository.Get(id);
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public bool Remove(Order item)
        {
            return _orderRepository.Remove(item);
        }

        public void Update(Order item)
        {
            Order oldorder = _orderRepository.Get(item.Id);
            int index = _orderRepository.IndexOf(oldorder);
            _orderRepository.Update(item, index);
        }
    }
}
