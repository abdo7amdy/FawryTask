Fawry E-Commerce System (C#)

This project implements a basic e-commerce system using C# and OOP principles developed for the "Fawry Quantum Internship Challenge".

Features:-

- Define products with name, price, and quantity
- Support for:
  - Expirable items (Cheese, Biscuits)
  - Non-expirable items (TV, ScratchCard)
  - Shippable items (with weight) vs non-shippable
- Customers can:-
  - Add items to a cart (with quantity validation)
  - Checkout items with validation:
    - Insufficient balance
    - Empty cart
    - Out of stock / expired items
- Shipping Service:
  - Handles shippable items via interface `IShippable`
  - Prints shipment details and total weight
- Console-based UI with clear receipt and shipment output

Technologies:-
- Language: C#
- IDE: Visual Studio 2022
- .NET Version: .NET 8


Example Usage:-
var customer = new Customer("Abdelrahman", 500);

var cheese = new Cheese("Cheese", 100, 10, DateTime.Now.AddDays(3), 0.2);
var biscuits = new Biscuits("Biscuits", 150, 5, DateTime.Now.AddDays(1), 0.7);
var scratchCard = new ScratchCard("ScratchCard", 50, 10);
var tv = new TV("TV", 300, 5, 5.0);

var cart = new Cart();
cart.Add(cheese, 2);
cart.Add(biscuits, 1);
cart.Add(scratchCard, 1);

