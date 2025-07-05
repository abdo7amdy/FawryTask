using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask.Classes
{

    public class Cart
    {
        private List<CartItem> items = new List<CartItem>();

        public void Add(Product product, int quantity)
        {
            if (quantity > product.Quantity)
            {
                Console.WriteLine("Quantity exceeds stock.");
                return;
            }

            items.Add(new CartItem(product, quantity));
        }

        public List<CartItem> GetItems() => items;

        public bool IsEmpty() => items.Count == 0;
    }

}
