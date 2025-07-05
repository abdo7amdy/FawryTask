using FawryTask.Interfaces;
using FawryTask.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FawryTask
{
    

    class Program
    {
        static void Main()
        {
            var customer = new Customer("Abdelrahman", 500);

            var cheese = new Cheese("Cheese", 100, 10, DateTime.Now.AddDays(3), 0.2);
            var biscuits = new Biscuits("Biscuits", 150, 5, DateTime.Now.AddDays(1), 0.7);
            var scratchCard = new ScratchCard("ScratchCard", 50, 10);
            var tv = new TV("TV", 300, 5, 5.0);

            var cart = new Cart();
            cart.Add(cheese, 2);
            cart.Add(biscuits, 1);
            cart.Add(scratchCard, 1);

            try
            {
                CheckoutService.Checkout(customer, cart);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}
