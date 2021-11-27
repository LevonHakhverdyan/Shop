using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Order
    {
        public Order()
        {
            Id = Guid.NewGuid();
            Products = new List<Product>();
        }
        public Guid  Id { get; set; }
        public string Name { get; set; }
        public DateTime orderDate { get; set; }
        public List<Product> Products { get; set; }
    }
}
