using System.Collections.Generic;

namespace Orders
{
    public class OrderBuilder
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public Order BuildOrder() => new Order()
        {
            Products = _products,
        };

        public Order GetOrder()
        {
            return BuildOrder();
        }
    }
}