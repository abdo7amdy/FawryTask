﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Product
{
    public string Name { get; }
    public double Price { get; }
    public int Quantity { get; private set; }

    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public abstract bool IsExpired();

    public void ReduceQuantity(int qty)
    {
        if (qty <= Quantity)
        {
            Quantity -= qty;
        }
    }
}

