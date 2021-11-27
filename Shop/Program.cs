using Shop.Models;
using Shop.Repository;
using Shop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        private static List<Product> products;

        static void Main(string[] args)
        {
            ProductRepository product = new ProductRepository();
            OrderRepository order1 = new OrderRepository();
            Product book = new Product() { Name = "book", Price = 800 }; 
            Product pen = new Product() { Name = "pen", Price = 70 };
            Product notebook = new Product() { Name = "notebook", Price = 150 };
            Product calculator = new Product() { Name = "calculator", Price = 2000 };
            Product chair = new Product() { Name = "chair", Price = 3000 };
            Product table = new Product() { Name = "table", Price = 5000 };
            Product picture = new Product() { Name = "picture", Price = 25000 };
            Product watch = new Product() { Name = "watch", Price = 9000 };
            Product paper = new Product() { Name = "paper", Price = 10 };
            Order stacionary = new Order() { Name = "stacionary", orderDate = DateTime.Now };
            products = new List<Product>() { book, pen, notebook, calculator, paper };
            Order inventory = new Order() { Name = "home", orderDate = DateTime.Now };
            products = new List<Product>() { chair,table,picture,watch };

            Productservice productservice = new Productservice(product);
            OrderService orderService = new OrderService(order1);

            productservice.Add(book);
            productservice.Add(pen);
            productservice.Add(notebook);
            productservice.Add(calculator);
            productservice.Add(chair);
            productservice.Add(table);
            productservice.Add(picture);
            productservice.Add(watch);
            productservice.Add(paper);

            orderService.Add(stacionary);
            orderService.Add(inventory);
            stacionary.Products.Add(book);
            stacionary.Products.Add(pen);
            stacionary.Products.Add(notebook);
            stacionary.Products.Add(calculator);

            inventory.Products.Add(chair);
            inventory.Products.Add(table);
            inventory.Products.Add(picture);
            inventory.Products.Add(watch);
            inventory.Products.Add(paper);

            var productCount = orderService.GetAll().Sum(x=>x.Products.Count);
            //int sum = 0;
            //foreach (var order in orders)
            //{
            //    sum += order.Products.Count;
            //}
            var stacionaryoryOrder = orderService.Get(stacionary.Id);
            //decimal orderPrice = 0;
            //foreach (var item in order.Products)
            //{
            //    orderPrice += item.Price;
            //}
            decimal stacionaryoryOrderPrice = stacionaryoryOrder.Products.Sum(x => x.Price);
            int stacionaryOrderProductsCount = stacionaryoryOrder.Products.Count;
            Console.WriteLine($"Total product number in the repository is: {productCount}");
            var inventoryoryOrder = orderService.Get(inventory.Id);
            decimal inventoryoryOrderPrice = inventoryoryOrder.Products.Sum(x => x.Price);
            int inventoryoryOrderProductsCount = inventoryoryOrder.Products.Count;


            Console.WriteLine($"Total price for stacionary is: {stacionaryoryOrderPrice}" + $" total count is:{stacionaryOrderProductsCount}");
            Console.WriteLine($"Total price for inventory is: {inventoryoryOrderPrice}" + $" total count is:{inventoryoryOrderProductsCount}");
            Console.ReadKey();








        }
    }
}
