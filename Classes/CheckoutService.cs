using FawryTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask.Classes
{
    public class CheckoutService
    {
        public static void Checkout(Customer customer, Cart cart)
        {
            if (cart.IsEmpty()) throw new Exception("Cart is empty.");

            double subtotal = 0;
            double shipping = 0;
            var shippableItems = new List<IShippable>();

            foreach (var item in cart.GetItems())
            {
                var product = item.Product;

                if (product is IExpirable expirable && expirable.IsExpired())
                    throw new Exception($"{product.Name} is expired.");

                if (item.Quantity > product.Quantity)
                    throw new Exception($"{product.Name} is out of stock.");

                subtotal += item.GetTotalPrice();

                if (product is IShippable shippable)
                {
                    for (int i = 0; i < item.Quantity; i++)
                    {
                        shippableItems.Add(shippable);
                        shipping += 15;
                    }
                }
            }

            double total = subtotal + shipping;
            if (customer.Balance < total)
                throw new Exception("Insufficient balance.");

            if (shippableItems.Count > 0)
                ShippingService.Ship(shippableItems);

            customer.Deduct(total);

            foreach (var item in cart.GetItems())
                item.Product.ReduceQuantity(item.Quantity);

            Console.WriteLine("** Checkout receipt **");
            foreach (var item in cart.GetItems())
            {
                Console.WriteLine($"{item.Quantity}x {item.Product.Name}");
                Console.WriteLine($"{item.GetTotalPrice()}");
            }

            Console.WriteLine("----------------------");
            Console.WriteLine($"Subtotal\n{subtotal}");
            Console.WriteLine($"Shipping\n{shipping}");
            Console.WriteLine($"Amount\n{total}");
            Console.WriteLine($"Remaining Balance\n{customer.Balance}");
        }
    }

}
