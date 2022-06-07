using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var water = new Product()
            {
                ProductId = 1,
                Name = "Water"
            };
            
            var chips = new Product()
            {
                ProductId = 2,
                Name = "Chips"
            };
            
            var orderBuilder = new OrderBuilder();
            var order = orderBuilder.GetOrder();

            orderBuilder.AddProduct(water);
            orderBuilder.AddProduct(chips);
            orderBuilder.BuildOrder();
            
            foreach (var product in order.Products)
            {
                Console.WriteLine($"id: {product.ProductId}, {product.Name}");
            }
            
        }
    }
}